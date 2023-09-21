﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public SQLRegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await nZWalksDbContext.Regions.AddAsync(region);
            await nZWalksDbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var existingRegion = await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);

            if (existingRegion == null)
            {
                return null;
            }

            nZWalksDbContext.Regions.Remove(existingRegion);
            await nZWalksDbContext.SaveChangesAsync();

            return existingRegion;

        }

        public async Task<List<Region>> GetAllAsync() 
            => await nZWalksDbContext.Regions.ToListAsync();

        public async Task<Region?> GetByIdAsync(Guid id) 
            => await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);

            if (existingRegion == null)
            {
                return null;
            }

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;

            await nZWalksDbContext.SaveChangesAsync();

            return existingRegion;
        }
    }
}
