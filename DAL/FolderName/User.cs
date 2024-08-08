using System;
using System.Collections.Generic;

namespace DAL.FolderName
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public string PasswordHash { get; set; } = null!;
        public int? PermissionId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Permission? Permission { get; set; }
    }
}
