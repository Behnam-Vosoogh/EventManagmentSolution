﻿using EventManagment.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Repositories
{
    public interface IUnitOfWork
    {
        IUserProfilesRepository UserProfiles { get; }
        // .. Other Repositories will go here 

        Task CommitChangesAsync();
    }
    public class EfUnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _db;

        public EfUnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        private IUserProfilesRepository _userProfiles;

        public IUserProfilesRepository UserProfiles
        {
            get
            {
                if (_userProfiles == null)
                    _userProfiles = new UserProfilesRepository(_db);

                return _userProfiles;
            }
        }

        public async Task CommitChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

    }
}
