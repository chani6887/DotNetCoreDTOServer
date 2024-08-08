using System;
using System.Collections.Generic;

namespace DAL.FolderName
{
    public partial class Permission
    {
        public Permission()
        {
            Users = new HashSet<User>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
