using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Models
{
    public enum Action { Addition, Removal, Editing, Movement }
    public class Sheet
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string StorageName { get; set; } = null!;
        public Action ActionType { get; set; }
        public string? OldStorageName { get; set; }
    }
}
