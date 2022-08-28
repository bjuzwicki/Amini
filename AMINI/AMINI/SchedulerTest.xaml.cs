using Syncfusion.SfSchedule.XForms;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AMINI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulerTest : ContentPage
    {
        MainViewModel mainView;
        
        public SchedulerTest(MainViewModel mainView)
        {
            InitializeComponent();
            this.mainView = new MainViewModel(mainView);
            BindingContext = mainView;
            schedule.CellTapped += Schedule_CellTapped;
            schedule.CellDoubleTapped += Schedule_CellDoubleTapped;
            //schedule.CellLongPressed += Schedule_CellLongPressed;
            schedule.MonthInlineAppointmentTapped += Schedule_MonthInlineAppointmentTapped;
            popupLayoutEdit.PopupView.AcceptCommand = new Command(PopupAccept);
            schedule.DataSource=mainView.ScheduleAppointmentCollection;
        }

        private void buttonDay_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.DayView;
        }

        private void buttonWeek_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.WeekView;
        }
        private void buttonMonth_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.MonthView;
        }

        private void Schedule_CellTapped(object sender, CellTappedEventArgs e)
        {
            if (e.Appointment != null)
            {
                var thisEvent = (e.Appointment as Event);
                //Debug.WriteLine("a2 " + thisEvent.Subject + " " + thisEvent.StartTime);
                mainView.SetEventLayoutPreviewData(thisEvent);
                BindingContext = mainView;
                SetDataTemplate(popupLayoutPreview);
                popupLayoutPreview.Show();
            }
        }
        //private void Schedule_CellLongPressed(object sender, CellTappedEventArgs e)
        //{
        //    AddNewEvent(e);   
        //}

        private void Schedule_CellDoubleTapped(object sender, CellTappedEventArgs e)
        {
           AddNewEvent(e); 
        }

        private void Schedule_MonthInlineAppointmentTapped(object sender, MonthInlineAppointmentTappedEventArgs e)
        {
            if (e.Appointment != null)
            {
                var thisEvent = (e.Appointment as Event);
                //Debug.WriteLine("a2 " + thisEvent.Subject + " " + thisEvent.StartTime);
                mainView.SetEventLayoutPreviewData(thisEvent);
                BindingContext = mainView;
                SetDataTemplate(popupLayoutPreview);
                popupLayoutPreview.Show();
            }
        }

        private void PopupAccept()
        {       
            mainView.ScheduleAppointmentCollection.Add(new Event(mainView));
            schedule.DataSource=mainView.ScheduleAppointmentCollection;
        }

        private void SetDataTemplate(SfPopupLayout popupLayout)
        {
            popupLayout.PopupView.HeaderTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                if(string.IsNullOrEmpty(mainView.Title))
                {
                   mainView.Title = "Nowy termin zajęć";
                }
                var nameLabel = new Label {Text = mainView.Title, VerticalTextAlignment=TextAlignment.Center,  HorizontalTextAlignment=TextAlignment.Center, FontAttributes=FontAttributes.Bold, FontSize=18, TextColor=Color.FromHex("#2196F3")};
            
                //nameLabel.SetBinding(Label.TextProperty, "Title",BindingMode.OneWay);
                grid.Children.Add(nameLabel);

                return new ViewCell { View = grid };
            });
        }

        private void AddNewEvent(CellTappedEventArgs e)
        {
            mainView.SetEventLayoutEditData(e);

            BindingContext = mainView;

            SetDataTemplate(popupLayoutEdit);
       
            popupLayoutEdit.Show();    
        }

        private void buttonAddNewEvent_Clicked(object sender, EventArgs e)
        {
            AddNewEvent(null);
        }
    }
}