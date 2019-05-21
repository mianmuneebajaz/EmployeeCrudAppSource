using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersCrudApp.WebUI
{
    public static class WebHelper
    {
        static WebHelper()
        {
            m = new Mapper(new MapperConfiguration(new AutoMapper.Configuration.MapperConfigurationExpression()));
        }
        static Mapper m;
        public static List<Models.UserModel> ToViewModels(this IEnumerable<UsersCrudApp.UsersMgt.User> dataModels)
        {
            List<Models.UserModel> temp = new List<Models.UserModel>();
            foreach (var item in dataModels)
            {
                temp.Add(m.DefaultContext.Mapper.Map<Models.UserModel>(item));
            }
            return temp;

        }
        public static Models.UserModel ToViewModel(this UsersCrudApp.UsersMgt.User dataModel)
        {
            return m.DefaultContext.Mapper.Map<Models.UserModel>(dataModel);
        }
        public static List<UsersMgt.User> ToDataModels(this IEnumerable<Models.UserModel> viewModels)
        {
            List<UsersMgt.User> temp = new List<UsersMgt.User>();
            foreach (var item in viewModels)
            {
                temp.Add(m.DefaultContext.Mapper.Map<UsersMgt.User>(item));
            }
            return temp;
        }
        public static UsersMgt.User toDataModel(this Models.UserModel viewModel)
        {
            return m.DefaultContext.Mapper.Map<UsersMgt.User>(viewModel);
        }
    }
}