using ImageAlerm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImageAlerm.ViewModel
{
    class AlermListDataViewModel : BindableObject,INotifyPropertyChanged
    {
        //ObservableCollection 의 변화를 자동으로 감지하여 UI 화면을 자동으로 갱신.
        
        private ObservableCollection<AlermListDataModel> _AlermListDataModel = new ObservableCollection<AlermListDataModel>();
        public ICommand Listcommand { get; set; }
        public ObservableCollection<AlermListDataModel> AlermListDataModel
        {
            get
            {
                return _AlermListDataModel;
            }
            set
            {
                _AlermListDataModel = value;
                OnPropertyChanged(nameof(AlermListDataModel));
            }
        }
        public AlermListDataViewModel()
        { 
            AlermListDataModel = new ObservableCollection<AlermListDataModel>();
            Listcommand = new Command(() =>listadd());
        }

        public void listadd()
        {

            AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오전",
                alermDay = "월요일",
                alermTime = "16시"
            });
            AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오후",
                alermDay = "월요일",
                alermTime = "16시"
            });
            AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오전",
                alermDay = "화요일",
                alermTime = "16시"
            });
            
        }
    }
}
