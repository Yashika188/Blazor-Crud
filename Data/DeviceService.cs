using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudAssignment.Data
{
    public class DeviceService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public DeviceService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Devices
        public async Task<List<Device>> GetAllDeviceAsync()
        {
            return await _appDBContext.Devices.ToListAsync();
        }
        #endregion

        #region Insert Device
        public async Task<bool> InsertDeviceAsync(Device insertD)
        {
            await _appDBContext.Devices.AddAsync(insertD);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Device by Id
        public async Task<Device> GetDeviceAsync(int Id)
        {
            Device op = await _appDBContext.Devices.FirstOrDefaultAsync(c => c.DeviceID.Equals(Id));
            return op;
        }
        #endregion

        #region Update Device
        public async Task<bool> UpdateDeviceAsync(Device updateOp)
        {
            _appDBContext.Devices.Update(updateOp);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteDevice
        public async Task<bool> DeleteDeviceAsync(Device delOp)
        {
            _appDBContext.Remove(delOp);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
