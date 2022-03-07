using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public interface IOperationDeviceService
    {
        public Task<List<OperationDeviceModel>> GetAllOperations();
        void AddOperation(OperationDeviceModel model, int OrderInWhichToPerform);
        void UpdateDevice(int OperationId, string DeviceName, int DeviceType);
        public Task<OperationDeviceModel> GetOperationData(int id);
        void DeleteOperation(int id);
    }
    public class OperationDeviceService : IOperationDeviceService
    {
        private BlazorAppDBContext _context;
        public OperationDeviceService(BlazorAppDBContext context)
        {
            _context = context;
        }

        public void AddOperation(OperationDeviceModel model, int OrderInWhichToPerform)
        {
            try
            {
                Models.Device modelObj = new Models.Device();
                modelObj.DeviceType = (int)model.Device.DeviceType;
                modelObj.Name = model.Device.Name;
                _context.Device.Add(modelObj);
                _context.SaveChanges();

                Operation openModel = new Operation();
                openModel.Name = model.Name;
                openModel.OrderInWhichToPerform = OrderInWhichToPerform;
                openModel.DeviceId = modelObj.DeviceId;
                openModel.ImageData = model.ImageData;
                _context.Operation.Add(openModel);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteOperation(int id)
        {

            var operation = _context.Operation.Where(x => x.OperationId == id).FirstOrDefault();
            var device = _context.Device.Where(x => x.DeviceId == operation.DeviceId).FirstOrDefault();

            _context.Remove(operation);
            _context.Remove(device);
            _context.SaveChangesAsync();
        }

        public async Task<List<OperationDeviceModel>> GetAllOperations()
        {
            try
            {
                var operationList = _context.Operation.ToList();
                List<OperationDeviceModel> modelList = new List<OperationDeviceModel>();
                foreach (var item in operationList)
                {
                    OperationDeviceModel modelObj = new OperationDeviceModel();
                    modelObj.OperationID = item.OperationId;
                    modelObj.Name = item.Name;
                    modelObj.OrderInWhichToPerform = (int)item.OrderInWhichToPerform;
                    item.Device = _context.Device.Where(x => x.DeviceId == item.DeviceId).FirstOrDefault();
                    Device obj = new Device();
                    obj.DeviceID = item.Device.DeviceId;
                    obj.Name = item.Device.Name;
                    obj.DeviceType = (DeviceType)item.Device.DeviceType;
                    modelObj.Device = obj;
                    modelList.Add(modelObj);
                }
                return modelList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<OperationDeviceModel> GetOperationData(int id)
        {
            try
            {
                OperationDeviceModel modelObj = new OperationDeviceModel();
                if (id == 0)
                {
                    return modelObj;
                }
                var operationObj = _context.Operation.Where(c => c.OperationId.Equals(id)).FirstOrDefault();
                modelObj.OperationID = operationObj.OperationId;
                modelObj.Name = operationObj.Name;
                modelObj.OrderInWhichToPerform = (int)operationObj.OrderInWhichToPerform;
                operationObj.Device = _context.Device.Where(x => x.DeviceId == operationObj.DeviceId).FirstOrDefault();
                Device obj = new Device();
                obj.DeviceID = operationObj.Device.DeviceId;
                obj.Name = operationObj.Device.Name;
                obj.DeviceType = (DeviceType)operationObj.Device.DeviceType;
                modelObj.Device = obj;

                return modelObj;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateDevice(int OperationId, string DeviceName, int DeviceType)
        {
            try
            {
                Models.Device modelObj = new Models.Device();
                modelObj.DeviceType = DeviceType;
                modelObj.Name = DeviceName;
                _context.Device.Add(modelObj);
                _context.SaveChanges();

                Operation openModel = new Operation();
                openModel = _context.Operation.Where(c => c.OperationId == OperationId).FirstOrDefault();
                openModel.DeviceId = modelObj.DeviceId;
                _context.Entry(openModel).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
