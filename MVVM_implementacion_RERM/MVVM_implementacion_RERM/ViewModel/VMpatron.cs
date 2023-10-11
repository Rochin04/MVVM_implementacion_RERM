using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_implementacion_RERM.ViewModel
{
    public class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        #endregion
        #region OBJETO
        public string Texto
        {
            get{ return _Texto; }
            set{ SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
    }
}
