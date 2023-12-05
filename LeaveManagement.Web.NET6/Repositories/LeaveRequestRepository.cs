using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Web.NET6.Contracts;
using LeaveManagement.Web.NET6.Data;
using LeaveManagement.Web.NET6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.NET6.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly AutoMapper.IConfigurationProvider _configurationProvider;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, 
            UserManager<Employee> userManager, ILeaveAllocationRepository leaveAllocationRepository,
            AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _leaveAllocationRepository = leaveAllocationRepository;
            _configurationProvider = configurationProvider;
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;

            if (approved)
            {
                var allocation = await _leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberOfDays -= daysRequested;

                await _leaveAllocationRepository.UpdateAsync(allocation);
            }

            await UpdateAsync(leaveRequest);
        }

        public async Task ChangeCancelStatus(int leaveRequestId)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Cancelled = true;

            await UpdateAsync(leaveRequest);
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            //var leaveRequests = await GetAllAsync();
            var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();

            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null && q.Cancelled == false),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                CancelledRequests = leaveRequests.Count(q => q.Cancelled == true),
                LeaveRequests = _mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            foreach (var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }

            return model;
        }

        public async Task<List<LeaveRequestVM>> GetAllAsync(string employeeId)
        {
            return await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId)
                .ProjectTo<LeaveRequestVM>(_configurationProvider)
                .ToListAsync();
        }

        public async Task<LeaveRequestVM?> GetLeaveRequest(int? id)
        {
            var leaveRequest = await _context.LeaveRequests
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (leaveRequest == null)
            {
                return null;
            }

            var model = _mapper.Map<LeaveRequestVM>(leaveRequest);

            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));

            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
            var allocations = (await _leaveAllocationRepository.GetEmployeeAllocationVM(user.Id)).LeaveAllocations;
            var requests = await GetAllAsync(user.Id);

            var model = new EmployeeLeaveRequestViewVM(allocations, requests);

            return model;
        }
    }
}
