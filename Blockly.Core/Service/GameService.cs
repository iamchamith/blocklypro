using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blockly.Core.Domain;
using Blockly.Core.Infrastructure;
using Blockly.Core.Model;
using Blockly.Core.Utility;
using Microsoft.EntityFrameworkCore;

namespace Blockly.Core.Service
{
    public class GameService : IGameService
    {
        public IUnitOfWork _unitOfWork { get; }
        public GameService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GameModel> CreateGame(GameModel item)
        {
            try
            {
                var result = await _unitOfWork.GameRepository.Create(Mapper.Map<Game>(item));
                await _unitOfWork.SaveAsync();
                return Mapper.Map<GameModel>(result);
            }
            catch (Exception e)
            {
                throw e.HandlException();
            }
            
        }

        public async Task<List<GameMapModel>> GetGameMap(int item)
        {
            try
            {
             return (await _unitOfWork.GameMapRepository.TableAsNoTracking.Where(p=>p.GameId==item).ToListAsync())
                .Select(AutoMapper.Mapper.Map<GameMapModel>).ToList();


            }
            catch (Exception e)
            {
                throw e.HandlException();
            }
        }

        public async Task<List<KeyValuePair<int, string>>> GetGames()
        {
            try
            {
                return (await _unitOfWork.GameRepository.TableAsNoTracking.ToListAsync())
                    .Select(p => new KeyValuePair<int, string>(p.Id, p.Name)).ToList();

            }
            catch (Exception e)
            {
                throw e.HandlException();
            }
        }

        public async Task SaveGameMap(GameMapRequest items)
        {
            using (var transaction = await _unitOfWork.Context.Database.BeginTransactionAsync())
            {
                try
                {
                    var mapps = await _unitOfWork.GameMapRepository.Table.Where(p => p.GameId == items.GameId).ToListAsync();
                    _unitOfWork.Context.RemoveRange(mapps);
                    await _unitOfWork.Context.SaveChangesAsync();
                    foreach (var item in items.Maps)
                    {
                        await _unitOfWork.GameMapRepository.Create(Mapper.Map<GameMap>(item));
                    }
                    await _unitOfWork.SaveAsync();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e.HandlException();
                }
            }
           
        }
    }
}
