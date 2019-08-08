using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AYQQMGR2018.Models
{
    public class ViewStartModel : Model
    {
        private bool viewIndex = true;

        public bool ViewIndex
        {
            get { return viewIndex; }
            set
            {
                if (viewIndex != value)
                {
                    viewIndex = value;
                    OnPropertyChanged("ViewIndex");
                }
            }
        }

        private bool viewShaDu = false;

        public bool ViewShaDu
        {
            get { return viewShaDu; }
            set
            {
                if (viewShaDu != value)
                {
                    viewShaDu = value;
                    OnPropertyChanged("ViewShaDu");
                }
            }
        }
        private bool viewLaJi = false;

        public bool ViewLaJi
        {
            get { return viewLaJi; }
            set
            {
                if (viewLaJi != value)
                {
                    viewLaJi = value;
                    OnPropertyChanged("ViewLaJi");
                }
            }
        }

        private bool viewJiaSu = false;

        public bool ViewJiaSu
        {
            get { return viewJiaSu; }
            set
            {
                if (viewJiaSu != value)
                {
                    viewJiaSu = value;
                    OnPropertyChanged("ViewJiaSu");
                }
            }
        }
        private bool viewFenXi = false;

        public bool ViewFenXi
        {
            get { return viewFenXi; }
            set
            {
                if (viewFenXi != value)
                {
                    viewFenXi = value;
                    OnPropertyChanged("ViewFenXi");
                }
            }
        }


        private bool viewZhenSuo = false;

        public bool ViewZhenSuo
        {
            get { return viewZhenSuo; }
            set
            {
                if (viewZhenSuo != value)
                {
                    viewZhenSuo = value;
                    OnPropertyChanged("ViewZhenSuo");
                }
            }
        }
    }
}
