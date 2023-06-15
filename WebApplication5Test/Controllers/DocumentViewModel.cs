using System.Collections.Generic;
using WebApplication5Test.Models;

namespace WebApplication5Test.Controllers
{
    internal class DocumentViewModel
    {
        public List<FileModel> Documents { get; set; }
        public List<string> Keywords { get; set; }
    }
}