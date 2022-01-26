using System;
using CodeLogic;
using CL.MySQL.ConfigModels;
using CL.Smtp.ConfigModels;
using Media2A.WebApp.ConfigModels;
using CL.MySQL;
using Microsoft.AspNetCore.Http;


namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string GenerateMenuByID(string menuName)
            {

                // Menu settings
                var currentMenuLevels = 0;
                var maxMenuLevels = 2;

                // Menu Database Model and data

                var menuModel = new WebApp_DatabaseModels.WebApp_CMS_Menus();
                var menuData = CL.MySQL.MySql_Queries.GetDataByModelByID(menuModel.ReturnTable(), menuModel.menu_name, menuName);

                // Menu items

                var menuItemsData = CL.MySQL.MySql_Queries.GetAllDataByModelByID(menuModel.ReturnTable(), menuModel.menu_id, menuName);

                menuModel.menu_id = MySql_Tools.GetRecordValue(menuData, menuModel.menu_id);
                menuModel.menu_name = MySql_Tools.GetRecordValue(menuData, menuModel.menu_name);
                menuModel.menu_description = MySql_Tools.GetRecordValue(menuData, menuModel.menu_description);
                menuModel.template_id = MySql_Tools.GetRecordValue(menuData, menuModel.template_id);


                // Get menu template

                var menuTemplate = GetTemplateByID(menuModel.template_id);

                // Menu

                var menuTemplateName = menuModel.menu_name + menuModel.menu_name + "_menu"; 
                // var MenuTemplate = CL.MySQL.MySql_Queries.GetDataByModelByID(templateModel.ReturnTable(), templateModel.template_id, menuTemplateName);

                // var test = MySql_Tools.GetRecordValue(MenuTemplate, templateModel.template_content);

                // Menu item

                var menuItemTemplateName = menuModel.menu_name + "_menuitem";
                // var MenuItemTemplate = CL.MySQL.MySql_Queries.GetDataByModelByID(templateModel.ReturnTable(), templateModel.template_id, menuItemTemplateName);


                foreach (var item in menuItemsData)
                {
                    // var test = item.GetValueOrDefault("");

                }

                return menuModel.menu_description;
            }

        }
        
    }
}
