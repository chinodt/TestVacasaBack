using System;
using System.Data;
using System.Reflection;

namespace Vacasa.API.Test.DAL.Mappers
{
    public static class Mapper<O, D>
    where O : class
    where D : class
    {
        #region static public
        public static D ToMapper(O origen)
        {
            D destino = (D)Activator.CreateInstance(typeof(D));
            foreach (PropertyInfo propiedadDestino in destino.GetType().GetProperties())
            {
                if (ExisteCampo(propiedadDestino, origen))
                {
                    propiedadDestino.SetValue(destino, origen.GetType().GetProperty(propiedadDestino.Name).GetValue(origen), null);
                }
            }
            return destino;
        }
        #endregion

        #region static private
        private static bool ExisteCampo(PropertyInfo propiedadDestino, O origen)
        {
            foreach (PropertyInfo propiedadOrigen in origen.GetType().GetProperties())
            {
                if (propiedadOrigen.Name == propiedadDestino.Name)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ExisteCampo(PropertyInfo prop, DataTable table)
        {
            return table.Columns.Contains(prop.Name);
        }
        #endregion
    }
}
