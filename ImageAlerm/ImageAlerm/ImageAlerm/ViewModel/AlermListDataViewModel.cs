using ImageAlerm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ImageAlerm.ViewModel
{
    class AlermListDataViewModel
    {
        //ObservableCollection 의 변화를 자동으로 감지하여 UI 화면을 자동으로 갱신.
        
        private ObservableCollection<AlermListDataModel> _AlermListDataModel = new ObservableCollection<AlermListDataModel>();
        public ObservableCollection<AlermListDataModel> AlermListDataModel
        {
            get
            {
                return _AlermListDataModel;
            }
            set
            {
                _AlermListDataModel = value;
            }
        }
        public AlermListDataViewModel()
        {
            AlermListDataModel = new ObservableCollection<AlermListDataModel>();
        }
    }
}
