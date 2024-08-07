﻿using ReservationSystem.Models.Requests.User;
using ReservationSystem.Models.Responses.User;

namespace ReservationSystem.Services.UserService.Interfaces
{
    public interface IAddUserService
    {
        Task<AddUserResponse> AddUser(AddUserRequest request);
    }
}
