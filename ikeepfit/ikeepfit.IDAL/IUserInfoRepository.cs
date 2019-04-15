using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ikeepfit.Model;
using System.Linq;

namespace ikeepfit.IDAL
{
public interface IUserInfoRepository
{
/// <summary>
/// 获取列表
/// </summary>
/// <param name="db">数据库上下文</param>
/// <returns>数据列表</returns>
IQueryable<mt_user> GetList(ikeepfitEF db);
/// <summary>
/// 创建一个实体
/// </summary>
/// <param name="entity">实体</param>
int Create(mt_user entity);
/// <summary>
/// 删除一个实体
/// </summary>
/// <param name="entity">主键ID</param>
int Delete(int id);
/// <summary>
/// 修改一个实体
/// </summary>
/// <param name="entity">实体</param>
int Edit(mt_user entity);
/// <summary>
/// 获得一个实体
/// </summary>
/// <param name="id">id</param>
/// <returns>实体</returns>
mt_user GetById(int id);
/// <summary>
/// 判断一个实体是否存在
/// </summary>
bool IsExist(int id);
}
}
