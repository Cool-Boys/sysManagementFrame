using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MCL.Management.DAL;
using MCL.Management.Models;

namespace MCL.Management.BLL
{
    public class sysroleuserBLL
    {
        sysroleuserDAL sysroleuserdal = new sysroleuserDAL(); 

        /// <summary>
        /// �Ƿ��������
        /// <summary>
        public int IsExist(sysroleuserModels _Wheresysroleuser)
        {
            return sysroleuserdal.IsExist(_Wheresysroleuser);
        }

        /// <summary>
        /// �鿴ȫ��
        /// <summary>
        public List<sysroleuserModels> selectAll()
        {
            return sysroleuserdal.selectAll();
        }

        /// <summary>
        /// ����������ѯ
        /// <summary>
        public List<sysroleuserModels> SelectByWhere(sysroleuserModels _Wheresysroleuser , Dictionary<string, string> _Sort, object _WhereType = null)
        {
            return sysroleuserdal.SelectByWhere(_Wheresysroleuser, _Sort, _WhereType);

        }

        /// <summary>
        /// ������ѯ
        /// <summary>
        public sysroleuserModels SelectByKey(sysroleuserModels _Wheresysroleuser)
        {
            return sysroleuserdal.SelectByKey(_Wheresysroleuser);
        }

        /// <summary>
        /// ��ҳ��ѯ
        /// <summary>
        public multiplePageModel<sysroleuserModels> SelectMultiple(sysroleuserModels _Wheresysroleuser, Dictionary<string, string> _Sort, int _Limit, int _Offset)
        {
            return sysroleuserdal.SelectMultiple(_Wheresysroleuser, _Sort, _Limit, _Offset);
        }

        /// <summary>
        /// ��ѯ��һ�е�һ��
        /// <summary>
        public object SelectScalar(string _ColumnName,sysroleuserModels _Wheresysroleuser, object _WhereType = null)
        {
            return sysroleuserdal.SelectScalar(_ColumnName, _Wheresysroleuser, _WhereType);
        }

        /// <summary>
        /// ����
        /// <summary>
        public int Insert(sysroleuserModels _Insertsysroleuser)
        {
            return sysroleuserdal.Insert(_Insertsysroleuser);
        }

        /// <summary>
        /// �����޸�
        /// <summary>
        public int UpdateByKey(sysroleuserModels _Updatesysroleuser)
        {
            return sysroleuserdal.UpdateByKey(_Updatesysroleuser);
        }

        /// <summary>
        /// ����ɾ��
        /// <summary>
        public int DeleteByKey(sysroleuserModels _Wheresysroleuser)
        {
            return sysroleuserdal.DeleteByKey(_Wheresysroleuser);
        }

        /// <summary>
        /// ����ɾ��
        /// <summary>
        public int DeleteByWhere(sysroleuserModels _Wheresysroleuser, object _WhereType = null)
        {
            return sysroleuserdal.DeleteByWhere(_Wheresysroleuser, _WhereType);
        }
    }
}
