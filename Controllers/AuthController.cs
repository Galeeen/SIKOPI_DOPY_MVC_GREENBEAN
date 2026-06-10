using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;
using SIKOPI_DOPY_MVC_GREENBEAN.Repositories;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Controllers
{
    public class AuthController
    {
        private readonly IRepositoriUser _repositoriUser;

        public AuthController()
        {
            _repositoriUser = new RepositoriUser();
        }

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username wajib diisi.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password wajib diisi.");

            User? user = _repositoriUser.AmbilByUsername(username);

            if (user == null)
                throw new Exception("Username tidak ditemukan.");

            if (user.PasswordHash != password)
                throw new Exception("Password salah.");

            return user;
        }
    }
}