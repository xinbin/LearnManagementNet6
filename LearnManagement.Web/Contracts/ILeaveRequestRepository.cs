﻿using LearnManagement.Web.Data;
using LearnManagement.Web.Models;

namespace LearnManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
    }
}
