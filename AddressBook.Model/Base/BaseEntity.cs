using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model.Base
{
   public class BaseEntity
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; } = new Guid();
        /// <summary>
        /// 创建时间
        /// </summary>

        [Column(Order = 2)]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        /// <summary>
        /// 创建人
        /// </summary>
        [Column(Order = 3)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Column(Order = 4)]
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改人
        /// </summary>
        [Column(Order = 5)]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Column(Order = 6)]
        public int SysVersion { get; set; } = 1;
        /// <summary>
        /// 是否被删除（伪删除）
        /// </summary>
        [Column(Order = 7)]
        public bool IsRemoved { get; set; }
    }
}
