using Microsoft.EntityFrameworkCore;
using Samvad_App.Server.Data;
using Samvad_App.Server.Models;
using System;

namespace Samvad_App.Server.Repository
{
    public class PostAssetRepository : IRepository<PostAsset>
    {
        ApplicationDbContext _dbContext;
        public PostAssetRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<PostAsset> CreateAsync(PostAsset _object)
        {
            var obj = await _dbContext.PostAsset.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
       
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostAsset>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<PostAsset>> GetAllPostByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<PostAsset> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<PostAsset> GetByIdAsync(long assetid)
        {
            throw new NotImplementedException();
           
        }
        public IQueryable<PostAsset> GetAllPostAsset()
        {
            return _dbContext.PostAsset.AsQueryable();
        }
        public async  Task<List<PostAsset>> GetByPostIdAsync(long postid)
        {
            List<PostAsset> pAssetList = await GetAllPostAsset().Where(u => u.postid == postid).ToListAsync(); 
            //await _dbContext.PostAsset.Select(x => x.postid == postid).ToListAsync();
            return pAssetList;
        }

        public Task UpdateAsync(PostAsset _object)
        {
            throw new NotImplementedException();
        }

        public Task<PostAsset> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostAsset>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
