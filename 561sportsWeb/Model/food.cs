using System;
namespace SP.Model
{
    /// <summary>
    /// equip:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class food
    {
        public food()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _pic;
        private string _memo;
        private DateTime? _atime;
        /// <summary>
        /// 编号
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 食物名称
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 食物图片
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// 食物描述
        /// </summary>
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? atime
        {
            set { _atime = value; }
            get { return _atime; }
        }
        #endregion Model

    }
}

