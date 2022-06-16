using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using CL.MySQL;
using System.ComponentModel;

namespace Media2A.WebApp.DataModels
{
    public partial class BaseModel
    {
        public class WebApp_CMS_Layouts
        {
            [Key]
            public string? layout_id { get; set; }
            [MaxLength(50)]
            public string? layout_content { get; set; }
            [MaxLength(50)]
            public string? theme_id { get; set; }

        }
    }
}