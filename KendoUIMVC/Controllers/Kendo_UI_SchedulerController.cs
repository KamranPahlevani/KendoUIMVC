using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_SchedulerController : Controller
    {

        /// <summary>
        /// allDayEventTemplate String|Function
        /// The template used to render the "all day" scheduler events.
        /// The fields which can be used in the template are:
        /// description String - the event description
        /// end Date - the event end date
        /// isAllDay Boolean - if true the event is "all day"
        /// resources Array - the event resources
        /// start Date - the event start date
        /// title String - the event title
        /// </summary>
        /// <returns></returns>
        public ActionResult allDayEventTemplate()
        {
            return View();
        }

        /// <summary>
        /// allDaySlot Boolean (default: true)
        /// If set to true the scheduler will display a slot for "all day" events.
        /// The option is a shorthand to the view's allDaySlot option.
        /// To define the daySlot visibility using a data- attribute set the views.allDaySlot option directly.
        /// </summary>
        /// <returns></returns>
        public ActionResult allDaySlot()
        {
            return View();
        }

        /// <summary>
        /// autoBind Boolean (default: true)
        /// If set to false the widget will not bind to the data source during initialization.
        /// In this case data binding will occur when the change event of the data source is fired.
        /// By default the widget will bind to the data source specified in the configuration.
        /// Setting autoBind to false is useful when multiple widgets are bound to the same data source.
        /// Disabling automatic binding ensures that the shared data source doesn't make more than one request to the remote service.
        /// </summary>
        /// <returns></returns>
        public ActionResult autoBind()
        {
            return View();
        }

        /// <summary>
        /// currentTimeMarker Boolean|Object
        /// If set to false the "current time" marker of the scheduler would not be displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult currentTimeMarker()
        {
            return View();
        }

        /// <summary>
        /// currentTimeMarker.updateInterval Number (default: 10000)
        /// The update interval of the "current time" marker, in milliseconds.
        /// </summary>
        /// <returns></returns>
        public ActionResult currentTimeMarker_updateInterval()
        {
            return View();
        }

        /// <summary>
        /// currentTimeMarker.useLocalTimezone Boolean (default: true)
        /// If set to false the "current time" marker would be displayed using the scheduler timezone.
        /// </summary>
        /// <returns></returns>
        public ActionResult currentTimeMarker_useLocalTimezone()
        {
            return View();
        }

        /// <summary>
        /// dataSource Object|Array|kendo.data.SchedulerDataSource
        /// The data source of the widget which contains the scheduler events. Can be a JavaScript object which represents a valid data source configuration, a JavaScript array or an existing kendo.data.SchedulerDataSource instance.
        /// If the dataSource option is set to a JavaScript object or array the widget will initialize a new kendo.data.SchedulerDataSource instance using that value as data source configuration.
        /// If the dataSource option is an existing kendo.data.SchedulerDataSource instance the widget will use that instance and will not initialize a new one.
        /// The Kendo UI Scheduler widget can be bound only to a kendo.data.SchedulerDataSource. An exception will be thrown if the dataSource option is set to a kendo.data.DataSource instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_dataSource_as_a_JavaScript_object()
        {
            return View();
        }

        public ActionResult set_dataSource_as_a_JavaScript_array()
        {
            return View();
        }

        public ActionResult set_dataSource_as_an_existing_kendo_data_SchedulerDataSource_instance()
        {
            return View();
        }

        /// <summary>
        /// date Date
        /// The current date of the scheduler.
        /// Used to determine the period which is displayed by the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult date()
        {
            return View();
        }

        /// <summary>
        /// dateHeaderTemplate String|Function
        /// The template used to render the date header cells.
        /// By default the scheduler renders the date using a custom date format - "ddd M/dd".
        /// The "ddd" specifier represents the abbreviated name of the week day and will be localized using the current Kendo UI culture.
        /// If the developer wants to control the day and month order, then one needs to define a custom template.
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// </summary>
        /// <returns></returns>
        public ActionResult dateHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// editable Boolean|Object (default: true)
        /// If set to true the user would be able to create new scheduler events and modify or delete existing ones.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable()
        {
            return View();
        }

        /// <summary>
        /// editable.confirmation Boolean|String (default: true)
        /// If set to true the scheduler will display a confirmation dialog when the user clicks the "destroy" button.
        /// Can be set to a string which will be used as the confirmation text.
        /// </summary>
        /// <returns></returns>
        public ActionResult disable_delete_confirmation()
        {
            return View();
        }

        public ActionResult set_delete_confirmation_text()
        {
            return View();
        }

        /// <summary>
        /// editable.create Boolean (default: true)
        /// If set to true the user can create new events. Creating is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_create()
        {
            return View();
        }

        /// <summary>
        /// editable.destroy Boolean (default: true)
        /// If set to true the user can delete events from the view by clicking the "destroy" button. Deleting is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_destroy()
        {
            return View();
        }

        /// <summary>
        /// editable.move Boolean (default: true)
        /// If set to true the scheduler allows event moving. Dragging the event changes the start and end time.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_move()
        {
            return View();
        }

        /// <summary>
        /// editable.resize Boolean (default: true)
        /// If set to true the scheduler allows event resizing. Dragging the resize handles changes the start or end time of the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_resize()
        {
            return View();
        }

        /// <summary>
        /// editable.template String|Function
        /// The template which renders the editor.
        /// The template should contain elements whose name HTML attributes are set as the editable fields.
        /// This is how the Scheduler will know which field to update. The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// Use the role data attribute to initialize Kendo UI widgets in the template. Check data attribute initialization for more info.
        /// </summary>
        /// <returns></returns>
        public ActionResult customize_the_popup_editor()
        {
            return View();
        }

        public ActionResult using_MVVM_in_the_popup_editor_template()
        {
            return View();
        }

        /// <summary>
        /// editable.update Boolean (default: true)
        /// If set to true the user can update events. Updating is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_update()
        {
            return View();
        }

        /// <summary>
        /// editable.window Object
        /// Configures the Kendo UI Window instance, which is used when the Grid edit mode is "popup". The configuration is optional.
        /// For more information, please refer to the Window configuration API.
        /// </summary>
        /// <returns></returns>
        public ActionResult editable_window()
        {
            return View();
        }

        /// <summary>
        /// endTime Date
        /// The end time of the week and day views. The scheduler will display events ending before the endTime.
        /// </summary>
        /// <returns></returns>
        public ActionResult endTime()
        {
            return View();
        }

        /// <summary>
        /// eventTemplate String|Function
        /// The template used to render the scheduler events.
        /// The fields which can be used in the template are:
        /// description String - the event description
        /// end Date - the event end date
        /// resources Array - the event resources
        /// start Date - the event start date
        /// title String - the event title
        /// </summary>
        /// <returns></returns>
        public ActionResult eventTemplate()
        {
            return View();
        }

        /// <summary>
        /// footer Boolean|Object
        /// If set to false the footer of the scheduler would not be displayed.
        /// </summary>
        /// <returns></returns>
        public ActionResult footer()
        {
            return View();
        }

        /// <summary>
        ///     footer.command String|Boolean (default: "workDay")
        /// Sets the command which will be displayed in the scheduler footer.
        /// Currently only "workDay" option is supported. If the option is set to false, the "workDay" button will be removed from the footer.
        /// </summary>
        /// <returns></returns>
        public ActionResult footer_command()
        {
            return View();
        }

        /// <summary>
        /// group Object
        /// The configuration of the scheduler resource(s) grouping.
        /// group.resources Array
        /// An array of resource names by which the scheduler events will be grouped.
        /// </summary>
        /// <returns></returns>
        public ActionResult group_resources()
        {
            return View();
        }

        /// <summary>
        /// group.orientation String (default: "horizontal")
        /// The orientation of the group headers. Supported values are horizontal or vertical.
        /// Note that the agenda view is always in vertical orientation.
        /// </summary>
        /// <returns></returns>
        public ActionResult group_orientation()
        {
            return View();
        }

        /// <summary>
        /// height Number|String
        /// The height of the widget. Numeric values are treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult height()
        {
            return View();
        }

        /// <summary>
        /// majorTick Number (default: 60)
        /// The number of minutes represented by a major tick.
        /// </summary>
        /// <returns></returns>
        public ActionResult majorTick()
        {
            return View();
        }

        /// <summary>
        /// majorTimeHeaderTemplate String|Function
        /// The template used to render the major ticks.
        /// By default the scheduler renders the time using the current culture time format.
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// </summary>
        /// <returns></returns>
        public ActionResult majorTimeHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// max Date (default: 31/12/2099)
        /// Constraints the maximum date which can be selected via the scheduler navigation.
        /// </summary>
        /// <returns></returns>
        public ActionResult max()
        {
            return View();
        }

        /// <summary>
        /// messages Object
        /// The configuration of the scheduler messages. Use this option to customize or localize the scheduler messages.
        /// messages.allDay String
        /// The text similar to "all day" displayed in day,week and agenda views.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_allDay()
        {
            return View();
        }

        /// <summary>
        /// messages.ariaEventLabel String(default: "{0} on {1:D} at {2:t}")
        /// Specifies the format string used to populate the aria-label attribute value of the selected event element.
        /// The arguments which can be used in the format string are:
        /// {0} - represents the title of the selected event.
        /// {1} - represents the start date of the event.
        /// {2} - represents the start time of the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_ariaEventLabel()
        {
            return View();
        }

        /// <summary>
        /// messages.ariaSlotLabel String(default: "Selected from {0:t} to {1:t}")
        /// Specifies the format string used to populate the aria-label attribute value of the selected slot element.
        /// The arguments which can be used in the format string are:
        /// {0} - represents the start date of the slot.
        /// {1} - represents the end date of the slot.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_ariaSlotLabel()
        {
            return View();
        }

        /// <summary>
        /// messages.cancel String
        /// The text similar to "Cancel" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_cancel()
        {
            return View();
        }

        /// <summary>
        /// messages.date String
        /// The text similar to "Date" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_date()
        {
            return View();
        }

        /// <summary>
        /// messages.deleteWindowTitle String
        /// The text similar to "Delete event" displayed as title of the scheduler delete event window.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_deleteWindowTitle()
        {
            return View();
        }

        /// <summary>
        /// messages.destroy String
        /// The text similar to "Delete" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_destroy()
        {
            return View();
        }

        /// <summary>
        /// messages.event String
        /// The text similar to "Event" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_event()
        {
            return View();
        }

        /// <summary>
        /// messages.defaultRowText String
        /// The text similar to "All events" displayed in timeline views when there is no vertical grouping.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_defaultRowTex()
        {
            return View();
        }

        /// <summary>
        /// messages.pdf String
        /// The text displayed by the PDF export button.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_pdf()
        {
            return View();
        }

        /// <summary>
        /// messages.save String
        /// The text similar to "Save" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_save()
        {
            return View();
        }

        /// <summary>
        /// messages.showFullDay String
        /// The text similar to "Show full day" used in scheduler "showFullDay" button.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_showFullDay()
        {
            return View();
        }

        /// <summary>
        /// messages.showWorkDay String
        /// The text similar to "Show business hours" used in scheduler "showWorkDay" button.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_showWorkDay()
        {
            return View();
        }

        /// <summary>
        /// messages.time String
        /// The text similar to "Time" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_time()
        {
            return View();
        }

        /// <summary>
        /// messages.today String
        /// The text similar to "Today" displayed in scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_today()
        {
            return View();
        }

        /// <summary>
        /// messages.editor Object
        /// The configuration of the scheduler editor messages. Use this option to customize or localize the scheduler editor messages.
        /// messages.editor.allDayEvent String
        /// The text similar to "All day event" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_allDayEvent()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.description String
        /// The text similar to "Description" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_description()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.editorTitle String
        /// The text similar to "Event" displayed as title of the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_editorTitle()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.end String
        /// The text similar to "End" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_end()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.endTimezone String
        /// The text similar to "End timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_endTimezone()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.repeat String
        /// The text similar to "Repeat" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_repeat()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.separateTimezones String
        /// The text similar to "Use separate start and end time zones" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_separateTimezones()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.start String
        /// The text similar to "Start" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_start()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.startTimezone String
        /// The text similar to "Start timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_startTimezone()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.timezone String
        /// The text similar to "Timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_timezone()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.timezoneEditorButton String
        /// The text similar to "Time zone" displayed as text of timezone editor button in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_timezoneEditorButton()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.timezoneEditorTitle String
        /// The text similar to "Timezones" displayed as title of timezone editor in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_timezoneEditorTitle()
        {
            return View();
        }

        /// <summary>
        /// messages.editor.title String
        /// The text similar to "Title of the event" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_editor_title()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor Object
        /// The configuration of the scheduler recurrence editor messages. Use this option to customize or localize the scheduler recurrence editor messages.
        /// messages.recurrenceEditor.daily Object
        /// The configuration of the scheduler recurrence editor daily messages. Use this option to customize or localize the scheduler recurrence editor daily messages.
        /// messages.recurrenceEditor.daily.interval String
        /// The text similar to " day(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_daily_interval()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.daily.repeatEvery String
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_daily_repeatEvery()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end Object
        /// The configuration of the scheduler recurrence editor end messages. Use this option to customize or localize the scheduler recurrence editor end messages.
        /// messages.recurrenceEditor.end.after String
        /// The text similar to "After " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_after()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end.occurrence String
        /// The text similar to " occurrence(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_occurrence()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end.label String
        /// The text similar to "End:" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_label()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end.never String
        /// The text similar to "Never" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_never()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end.mobileLabel String
        /// The text similar to "Ends" displayed in the adaptive version of the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_mobileLabel()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.end.on String
        /// The text similar to "On " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_end_on()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.frequencies Object
        /// The configuration of the scheduler recurrence editor frequencies messages. Use this option to customize or localize the scheduler recurrence editor frequencies messages.
        /// messages.recurrenceEditor.frequencies.daily String
        /// The text similar to "Daily" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_frequencies_daily()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.frequencies.monthly String
        /// The text similar to "Monthly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_frequencies_monthly()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.frequencies.never String
        /// The text similar to "Never" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_frequencies_never()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.frequencies.weekly String
        /// The text similar to "Weekly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_frequencies_weekly()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.frequencies.yearly String
        /// The text similar to "Yearly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_frequencies_yearly()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.monthly Object
        /// The configuration of the scheduler recurrence editor monthly messages. Use this option to customize or localize the scheduler recurrence editor monthly messages.
        /// messages.recurrenceEditor.monthly.day String
        /// The text similar to "Day " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_monthly_day()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.monthly.interval String
        /// The text similar to " month(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_monthly_interval()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.monthly.repeatEvery String
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_monthly_repeatEvery()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.monthly.repeatOn String
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_monthly_repeatOn()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.offsetPositions Object
        /// The configuration of the scheduler recurrence editor offsetPositions messages. Use this option to customize or localize the scheduler recurrence editor offsetPositions messages.
        /// messages.recurrenceEditor.offsetPositions.first String
        /// The text similar to "first" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_offsetPositions_first()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.offsetPositions.second String
        /// The text similar to "second" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_offsetPositions_second()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.offsetPositions.third String
        /// The text similar to "third" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_offsetPositions_third()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.offsetPositions.fourth String
        /// The text similar to "fourth" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_offsetPositions_fourth()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.offsetPositions.last String
        /// The text similar to "last" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_offsetPositions_last()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekly Object
        /// The configuration of the scheduler recurrence editor weekly messages. Use this option to customize or localize the scheduler recurrence editor weekly messages.
        /// messages.recurrenceEditor.weekly.interval String
        /// The text similar to " week(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekly_interval()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekly.repeatEvery String
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekly_repeatEvery()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekly.repeatOn String
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekly_repeatOn()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekdays Object
        /// The configuration of the scheduler recurrence editor week days messages. Use these options to customize or localize the scheduler recurrence editor weekdays messages.
        /// messages.recurrenceEditor.weekdays.day String
        /// The text similar to "day" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekdays_day()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekdays.weekday String
        /// The text similar to "weekday" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekdays_weekday()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.weekdays.weekend String
        /// The text similar to "weekend" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_weekdays_weekend()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.yearly Object
        /// The configuration of the scheduler recurrence editor yearly messages. Use this option to customize or localize the scheduler recurrence editor yearly messages.
        /// messages.recurrenceEditor.yearly.of String
        /// The text similar to " of " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_yearly_of()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.yearly.repeatEvery String
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_yearly_repeatEvery()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.yearly.repeatOn String
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_yearly_repeatOn()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceEditor.yearly.interval String
        /// The text similar to " year(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceEditor_yearly_interval()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages Object
        /// The configuration of the scheduler recurrence messages. Use this option to customize or localize the scheduler recurrence messages.
        /// messages.recurrenceMessages.deleteRecurring String
        /// The text similar to "Do you want to delete only this event occurrence or the whole series?" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_deleteRecurring()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.deleteWindowOccurrence String
        /// The text similar to "Delete current occurrence" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_deleteWindowOccurrence()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.deleteWindowSeries String
        /// The text similar to "Delete the series" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_deleteWindowSeries()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.deleteWindowTitle String
        /// The text similar to "Delete Recurring Item" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_deleteWindowTitle()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.editRecurring String
        /// The text similar to "Do you want to edit only this event occurrence or the whole series?" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_editRecurring()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.editWindowOccurrence String
        /// The text similar to "Edit current occurrence" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_editWindowOccurrence()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.editWindowSeries String
        /// The text similar to "Edit the series" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_editWindowSeries()
        {
            return View();
        }

        /// <summary>
        /// messages.recurrenceMessages.editWindowTitle String
        /// The text similar to "Edit Recurring Item" displayed in the scheduler event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_recurrenceMessages_editWindowTitle()
        {
            return View();
        }

        /// <summary>
        /// messages.views Object
        /// The configuration of the scheduler views messages. Use this option to customize or localize the scheduler views messages.
        /// messages.views.day String
        /// The text similar to "Day" displayed as scheduler "day" view title.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_views_day()
        {
            return View();
        }

        /// <summary>
        /// messages.views.week String
        /// The text similar to "Week" displayed as scheduler "week" view title.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_views_week()
        {
            return View();
        }

        /// <summary>
        /// messages.views.month String
        /// The text similar to "Month" displayed as scheduler "month" view title.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_views_month()
        {
            return View();
        }

        /// <summary>
        /// messages.views.agenda String
        /// The text similar to "Agenda" displayed as scheduler "agenda" view title.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages_views_agenda()
        {
            return View();
        }

        /// <summary>
        /// min Date (default: 1/1/1900)
        /// Constraints the minimum date which can be selected via the scheduler navigation.
        /// </summary>
        /// <returns></returns>
        public ActionResult min()
        {
            return View();
        }

        /// <summary>
        /// minorTickCount Number (default:2)
        /// The number of time slots to display per major tick.
        /// Note that the minorTickCount value should set to number heigher than 0.
        /// </summary>
        /// <returns></returns>
        public ActionResult minorTickCount()
        {
            return View();
        }

        /// <summary>
        /// minorTimeHeaderTemplate String|Function
        /// The template used to render the minor ticks.
        /// By default the scheduler renders a "&nbsp;".
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// </summary>
        /// <returns></returns>
        public ActionResult minorTimeHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// mobile Boolean|String (default: false)
        /// If set to true and the scheduler is viewed on mobile browser it will use adaptive rendering.
        /// Can be set to a string phone or tablet which will force the widget to use adaptive rendering regardless of browser type.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_adaptive_rendering_auto_detect()
        {
            return View();
        }

        public ActionResult force_adaptive_rendering()
        {
            return View();
        }

        /// <summary>
        /// pdf Object
        /// Configures the Kendo UI Scheduler PDF export settings.
        /// pdf.author String (default: null)
        /// The author of the PDF document.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_author()
        {
            return View();
        }

        /// <summary>
        /// pdf.creator String (default: "Kendo UI PDF Generator")
        /// The creator of the PDF document.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_creator()
        {
            return View();
        }

        /// <summary>
        /// pdf.date Date
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_date()
        {
            return View();
        }

        /// <summary>
        /// pdf.fileName String (default: "Export.pdf")
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_fileName()
        {
            return View();
        }

        /// <summary>
        /// pdf.forceProxy Boolean (default: false)
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// pdf.keywords String (default: null)
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_keywords()
        {
            return View();
        }

        /// <summary>
        /// pdf.landscape Boolean (default: false)
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_landscape()
        {
            return View();
        }

        /// <summary>
        /// pdf.margin Object
        /// Specifies the margins of the page (numbers or strings with units). Supported units are "mm", "cm", "in" and "pt" (default).
        /// pdf.margin.bottom Number|String (default: 0)
        /// The bottom margin. Numbers are considered as "pt" units.
        /// pdf.margin.left Number|String (default: 0)
        /// The left margin. Numbers are considered as "pt" units.
        /// pdf.margin.right Number|String (default: 0)
        /// The right margin. Numbers are considered as "pt" units.
        /// pdf.margin.top Number|String (default: 0)
        /// The top margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_margin()
        {
            return View();
        }

        /// <summary>
        /// pdf.paperSize String|Array (default: "auto")
        /// Specifies the paper size of the PDF document. The default "auto" means paper size is determined by content.
        /// The size of the content in pixels will match the size of the output in points (1 pixel = 1/72 inch).
        /// Supported values:
        /// A predefined size: "A4", "A3" etc
        /// An array of two numbers specifying the width and height in points (1pt = 1/72in)
        /// An array of two strings specifying the width and height in units. Supported units are "mm", "cm", "in" and "pt".
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_paperSize()
        {
            return View();
        }

        /// <summary>
        /// pdf.proxyURL String (default: null)
        /// The URL of the server side proxy which will stream the file to the end user.
        /// A proxy will be used when the browser isn't capable of saving files locally. Such browsers are IE version 9 and lower and Safari.
        /// The developer is responsible for implementing the server-side proxy.
        /// The proxy will receive a POST request with the following parameters in the request body:
        /// contentType: The MIME type of the file
        /// base64: The base-64 encoded file content
        /// fileName: The file name, as requested by the caller.
        /// The proxy should return the decoded file with set "Content-Disposition" header.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_proxyURL()
        {
            return View();
        }

        /// <summary>
        /// pdf.proxyTarget String (default: "_self")
        /// A name or keyword indicating where to display the document returned from the proxy.
        /// If you want to display the document in a new window or iframe, the proxy should set the "Content-Disposition" header to inline; filename="<fileName.pdf>".
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_proxyTarget()
        {
            return View();
        }

        /// <summary>
        /// pdf.subject String (default: null)
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_subject()
        {
            return View();
        }

        /// <summary>
        /// pdf.title String (default: null)
        /// Sets the title of the PDF file.
        /// </summary>
        /// <returns></returns>
        public ActionResult pdf_title()
        {
            return View();
        }

        /// <summary>
        /// resources Array
        /// The configuration of the scheduler resource(s). A scheduler resource is optional metadata that can be associated with a scheduler event.
        /// resources.dataColorField String (default: "color")
        /// The field of the resource data item which contains the resource color.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_dataColorField()
        {
            return View();
        }

        /// <summary>
        /// resources.dataSource Object|Array|kendo.data.DataSource
        /// The data source which contains resource data items. Can be a JavaScript object which represents a valid data source configuration, a JavaScript array or an existing kendo.data.DataSource instance.
        /// If the dataSource option is set to a JavaScript object or array the widget will initialize a new kendo.data.DataSource instance using that value as data source configuration.
        /// If the dataSource option is an existing kendo.data.DataSource instance the widget will use that instance and will not initialize a new one.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_dataSource()
        {
            return View();
        }

        /// <summary>
        /// resources.dataTextField String (default: "text")
        /// The field of the resource data item which represents the resource text.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_dataTextField()
        {
            return View();
        }

        /// <summary>
        /// resources.dataValueField String (default: "value")
        /// The field of the resource data item which represents the resource value. The resource value is used to link a scheduler event with a resource.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_dataValueField()
        {
            return View();
        }

        /// <summary>
        /// resources.field String
        /// The field of the scheduler event which contains the resource id.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_field()
        {
            return View();
        }

        /// <summary>
        /// resources.multiple Boolean (default: false)
        /// If set to true the scheduler event can be assigned multiple instances of the resource. The scheduler event field specified via the field option will contain an array of resources. By default only one resource instance can be assigned to an event.
        /// Example - multiple resources
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_multiple()
        {
            return View();
        }

        /// <summary>
        /// resources.name String
        /// The name of the resource used to distinguish resource. If not set the value of the field option is used.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_name()
        {
            return View();
        }

        /// <summary>
        /// resources.title String
        /// The user friendly title of the resource displayed in the scheduler edit form. If not set the value of the field option is used.
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_title()
        {
            return View();
        }

        /// <summary>
        /// resources.valuePrimitive Boolean (default: true)
        /// Set to false if the scheduler event field specified via the field option contains a resource data item.
        /// By default the scheduler expects that field to contain a primitive value (string, number) which corresponds to the "value" of the resource (specified via dataValueField).
        /// </summary>
        /// <returns></returns>
        public ActionResult resources_valuePrimitive()
        {
            return View();
        }

        /// <summary>
        /// selectable Boolean (default: false)
        /// If set to true the user would be able to select scheduler cells and events. By default selection is disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult selectable()
        {
            return View();
        }

        /// <summary>
        /// showWorkHours Boolean (default: false)
        /// If set to true the view will be initially shown in business hours mode. By default view is displayed in full day mode.
        /// The showWorkHours option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult showWorkHours()
        {
            return View();
        }

        /// <summary>
        /// snap Boolean (default: true)
        /// If set to true the scheduler will snap events to the nearest slot during dragging (resizing or moving). Set it to false to allow free moving and resizing of events.
        /// </summary>
        /// <returns></returns>
        public ActionResult snap()
        {
            return View();
        }

        /// <summary>
        /// startTime Date
        /// The start time of the week and day views. The scheduler will display events starting after the startTime.
        /// </summary>
        /// <returns></returns>
        public ActionResult startTime()
        {
            return View();
        }

        /// <summary>
        /// timezone String
        /// The timezone which the scheduler will use to display the scheduler appointment dates. By default the current system timezone is used. This is an acceptable default when the scheduler widget is bound to local array of events. It is advisable to specify a timezone if the scheduler is bound to a remote service. That way all users would see the same dates and times no matter their configured system timezone.
        /// The complete list of the supported timezones is available in the List of IANA time zones Wikipedia page.
        /// The kendo.timezones.min.js file must be included in order to use timezones other than "Etc/UTC".
        /// The timezone option will not affect events if the widget's data source is initialized separately. In this case set the schema.timezone option directly.
        /// </summary>
        /// <returns></returns>
        public ActionResult timezone()
        {
            return View();
        }

        /// <summary>
        /// toolbar Array
        /// List of commands that the scheduler will display in its toolbar as buttons. Currently supports only the "pdf" command.
        /// The "pdf" command exports the scheduler in PDF format.
        /// toolbar.name String
        /// The name of the command.
        /// </summary>
        /// <returns></returns>
        public ActionResult specify_the_toolbar_commands_as_array_of_strings()
        {
            return View();
        }

        public ActionResult specify_the_toolbar_commands_as_array_of_objects()
        {
            return View();
        }

        /// <summary>
        /// views Array
        /// The views displayed by the scheduler and their configuration.
        /// The array items can be either objects specifying the view configuration or strings representing the view types (assuming default configuration).
        /// By default the Kendo UI Scheduler widget displays "day" and "week" view.
        /// </summary>
        /// <returns></returns>
        public ActionResult set_views_as_array_of_strings()
        {
            return View();
        }

        public ActionResult set_views_as_array_of_objects()
        {
            return View();
        }

        /// <summary>
        /// views.allDayEventTemplate String|Function
        /// The template used to render the "all day" scheduler events.
        /// The fields which can be used in the template are:
        /// description String - the event description
        /// end Date - the event end date
        /// resources Array - the event resources
        /// start Date - the event start date
        /// title String - the event title
        /// The allDayEventTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_allDayEventTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.allDaySlot Boolean (default: true)
        /// If set to true the scheduler will display a slot for "all day" events.
        /// The allDaySlot option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_allDaySlot()
        {
            return View();
        }

        /// <summary>
        /// views.allDaySlotTemplate String|Function
        /// The template used to render the all day slot cell.
        /// The fields which can be used in the template are:
        /// date - represents the slot date.
        /// resources() - returns the relevant resources for the current slot.
        /// The allDaySlotTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_date_header_template()
        {
            return View();
        }

        public ActionResult modify_the_all_day_slot_based_on_resources()
        {
            return View();
        }

        /// <summary>
        /// The width of the table columns in timeline views. Value is treated as pixels.
        /// The columnWidth option is supported when views.type is set to "timeline", "timelineWeek", "timelineWorkWeek" or "timelineMonth".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_columnWidth()
        {
            return View();
        }

        /// <summary>
        /// views.dateHeaderTemplate String|Function
        /// The template used to render the date header cells.
        /// By default the scheduler renders the date using a custom date format - "ddd M/dd". The "ddd" specifier, a.k.a abbreviated name of the week day, will be localized using the current Kendo UI culture.
        /// If the developer wants to control the day and month order then one needs to define a custom template.
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// The dateHeaderTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_dateHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.dayTemplate String|Function
        /// The template used to render the day slots in month view.
        /// The fields which can be used in the template are:
        /// date Date - represents the current day
        /// resources() - returns the relevant resources for the current slot.
        /// The dayTemplate option is supported when views.type is set to "month".
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_day_template_in_month_view()
        {
            return View();
        }

        public ActionResult modify_the_day_slot_based_on_resources()
        {
            return View();
        }

        /// <summary>
        /// views.editable Boolean|Object (default: true)
        /// If set to true the user would be able to create new scheduler events and modify or delete existing ones.
        /// Overrides the editable option of the scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_editable()
        {
            return View();
        }

        /// <summary>
        /// views.editable.create Boolean (default: true)
        /// If set to true the user can create new events. Creating is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_editable_create()
        {
            return View();
        }

        /// <summary>
        /// views.editable.destroy Boolean (default: true)
        /// If set to true the user can delete events from the view by clicking the "destroy" button. Deleting is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_editable_destroy()
        {
            return View();
        }

        /// <summary>
        /// views.editable.update Boolean (default: true)
        /// If set to true the user can update events. Updating is enabled by default.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_editable_update()
        {
            return View();
        }

        /// <summary>
        /// views.endTime Date
        /// The end time of the view. The scheduler will display events ending before the endTime.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_endTime()
        {
            return View();
        }

        /// <summary>
        /// views.eventDateTemplate
        /// The template used by the agenda view to render the date of the scheduler events.
        /// The fields which can be used in the template are:
        /// date Date - represents the event date.
        /// The eventDateTemplate option is supported when views.type is set to "agenda".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_eventDateTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.eventHeight Number (default: 25)
        /// The height of the scheduler event rendered in month and timeline views.
        /// The eventHeight option is supported when views.type is set to "month", "timeline", "timelineWeek", "timelineWorkWeek" or "timelineMonth".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_eventHeight()
        {
            return View();
        }

        /// <summary>
        /// views.eventTemplate String|Function
        /// The template used by the view to render the scheduler events.
        /// The fields which can be used in the template are:
        /// description String - the event description
        /// end Date - the event end date
        /// resources Array - the event resources
        /// start Date - the event start date
        /// title String - the event title
        /// </summary>
        /// <returns></returns>
        public ActionResult views_eventTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.eventTimeTemplate String|Function
        /// The template used by the agenda view to render the time of the scheduler events.
        /// The fields which can be used in the template are:
        /// description String - the event description
        /// end Date - the event end date
        /// isAllDay Boolean - if true the event is "all day"
        /// resources Array - the event resources
        /// start Date - the event start date
        /// title String - the event title
        /// The eventTimeTemplate option is supported when views.type is set to "agenda".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_eventTimeTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.group Object
        /// The configuration of the view resource(s) grouping.
        /// views.group.orientation String (default: "horizontal")
        /// The orientation of the group headers. Supported values are horizontal or vertical. Note that the agenda view is always in vertical orientation.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_group_orientation()
        {
            return View();
        }

        /// <summary>
        /// groupHeaderTemplate String|Function
        /// The template used to render the group headers of scheduler day, week, workWeek and timeline views.
        /// The fields which can be used in the template are:
        /// text String - the group text
        /// color String - the group color
        /// value - the group value
        /// field String - the field of the scheduler event which contains the resource id
        /// title String - the 'title' option of the resource
        /// name String - the 'name' option of the resource
        /// </summary>
        /// <returns></returns>
        public ActionResult groupHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.majorTick Number (default: 60)
        /// The number of minutes represented by a major tick.
        /// The majorTick option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_majorTick()
        {
           return View();
        }

        /// <summary>
        /// views.majorTimeHeaderTemplate String|Function
        /// The template used to render the major ticks.
        /// By default the scheduler renders the time using the current culture time format.
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// The majorTimeHeaderTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_majorTimeHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.minorTickCount Number (default:2)
        /// The number of time slots to display per major tick.
        /// The minorTickCount option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_minorTickCount()
        {
            return View();
        }

        /// <summary>
        /// views.minorTimeHeaderTemplate String|Function
        /// The template used to render the minor ticks.
        /// By default the scheduler renders a "&nbsp;".
        /// The fields which can be used in the template are:
        /// date - represents the major tick date.
        /// The minorTimeHeaderTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_minorTimeHeaderTemplate()
        {
            return View();
        }

        /// <summary>
        /// views.selected Boolean (default: false)
        /// If set to true the view will be initially selected by the scheduler widget.
        /// If more than one view is selected then last of them will prevail.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_selected()
        {
            return View();
        }

        /// <summary>
        /// views.selectedDateFormat String
        /// The format used to display the selected date. Uses kendo.format.
        /// Contains two placeholders - "{0}" and "{1}" which represent the start and end date displayed by the view.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_selectedDateFormat()
        {
            return View();
        }

        /// <summary>
        /// views.showWorkHours Boolean (default: false)
        /// If set to true the view will be initially shown in business hours mode. By default view is displayed in full day mode.
        /// The showWorkHours option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_showWorkHours()
        {
            return View();
        }

        /// <summary>
        /// views.slotTemplate String|Function
        /// The template used to render the time slot cells.
        /// The fields which can be used in the template are:
        /// date - represents the slot date and time.
        /// resources() - returns the relevant resources for the current slot.
        /// The slotTemplate option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult set_the_slot_template()
        {
            return View();
        }

        public ActionResult modify_the_slot_based_on_resources()
        {
            return View();
        }

        /// <summary>
        /// views.startTime Date
        /// The start time of the view. The scheduler will display events starting after the startTime.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_startTime()
        {
            return View();
        }

        /// <summary>
        /// views.title String
        /// The user-friendly title of the view displayed by the scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult views_title()
        {
            return View();
        }

        /// <summary>
        /// views.type String
        /// The type of the view. The built-in views are: "day", "week", "workWeek", "month", "agenda", "timeline", "timelineWeek", "timelineWorkWeek" and "timelineMonth".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_type()
        {
            return View();
        }

        /// <summary>
        /// views.workWeekStart Number (default: 1)
        /// The start of working week (index based).
        /// The workWeekStart option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_workWeekStart()
        {
            return View();
        }

        /// <summary>
        /// views.workWeekEnd Number (default: 5)
        /// The end of working week (index based).
        /// The workWeekEnd option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult views_workWeekEnd()
        {
            return View();
        }

        /// <summary>
        /// width Number|String
        /// The width of the widget. Numeric values are treated as pixels.
        /// </summary>
        /// <returns></returns>
        public ActionResult width()
        {
            return View();
        }

        /// <summary>
        /// workDayStart Date
        /// Sets the start of the work day when the "Show business hours" button is clicked.
        /// </summary>
        /// <returns></returns>
        public ActionResult workDayStart()
        {
            return View();
        }

        /// <summary>
        /// workDayEnd Date
        /// Sets the end of the work day when the "Show business hours" button is clicked.
        /// </summary>
        /// <returns></returns>
        public ActionResult workDayEnd()
        {
            return View();
        }

        /// <summary>
        /// workWeekStart Number (default: 1)
        /// The start of working week (index based).
        /// The workWeekStart option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult workWeekStart()
        {
            return View();
        }

        /// <summary>
        /// workWeekEnd Number (default: 5)
        /// The end of working week (index based).
        /// The workWeekEnd option is supported when views.type is set to "day" or "week".
        /// </summary>
        /// <returns></returns>
        public ActionResult workWeekEnd()
        {
            return View();
        }

        /// <summary>
        /// dataSource kendo.data.SchedulerDataSource
        /// The data source of the widget. Configured via the dataSource option.
        /// Changes of the data source will be reflected in the widget.
        /// Assigning a new data source would have no effect. Use the setDataSource method instead.
        /// </summary>
        /// <returns></returns>
        public ActionResult add_a_data_item_to_the_data_source()
        {
            return View();
        }

        public ActionResult update_a_data_item_in_the_data_source()
        {
            return View();
        }

        public ActionResult remove_a_data_item_from_the_data_source()
        {
            return View();
        }

        /// <summary>
        /// addEvent
        /// Adds a new scheduler event and opens the edit form.
        /// Parameters
        /// data Object
        /// The object containing the scheduler event fields.
        /// </summary>
        /// <returns></returns>
        public ActionResult addEvent()
        {
            return View();
        }

        /// <summary>
        /// cancelEvent
        /// Cancels the scheduler event editing. Closes the edit form.
        /// </summary>
        /// <returns></returns>
        public ActionResult cancelEvent()
        {
            return View();
        }

        /// <summary>
        /// data
        /// Gets currently expanded scheduler events.
        /// </summary>
        /// <returns></returns>
        public ActionResult data()
        {
            return View();
        }

        /// <summary>
        /// date
        /// Gets or sets the current scheduler date.
        /// Parameters
        /// value Date (optional)
        /// The new date to set.
        /// Returns
        /// Date the current date.
        /// </summary>
        /// <returns></returns>
        public ActionResult date_method()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks. Calls destroy method of any child Kendo widgets.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// editEvent
        /// Opens the specified scheduler event in the edit form.
        /// Parameters
        /// event String|kendo.data.SchedulerEvent
        /// The event which should be put in edit mode. Also accepts a string which is the uid of the event which should be edited.
        /// </summary>
        /// <returns></returns>
        public ActionResult editEvent()
        {
            return View();
        }

        /// <summary>
        /// occurrenceByUid
        /// Gets the event occurrence with the specified uid.
        /// This method can return an occurrence (not part of the data source's data) part of a recurring series.
        /// Parameters
        /// uid String
        /// The uid of the occurrence to look for.
        /// Returns
        /// kendo.data.SchedulerEvent the occurrence instance. Returns undefined if an occurrence with the specified uid is not found.
        /// </summary>
        /// <returns></returns>
        public ActionResult occurrenceByUid()
        {
            return View();
        }

        /// <summary>
        /// occurrencesInRange
        /// Gets a list of event occurrences in specified time range.
        /// Parameters
        /// start Date
        /// The start date of the period.
        /// end Date
        /// The end date of the period.
        /// Returns
        /// Array a list of scheduler events filtered by the specified start/end period.
        /// All recurring events within the start - end period will be returned in the list.
        /// </summary>
        /// <returns></returns>
        public ActionResult occurrencesInRange()
        {
            return View();
        }

        /// <summary>
        /// refresh
        /// Refreshes the Scheduler rendering using the current data items.
        /// </summary>
        /// <returns></returns>
        public ActionResult refresh()
        {
            return View();
        }

        /// <summary>
        /// emoveEvent
        /// Removes the specified scheduler event.
        /// Parameters
        /// event String|kendo.data.SchedulerEvent
        /// The event which should be removed. Also accepts a string which is the uid of the event which should be removed.
        /// </summary>
        /// <returns></returns>
        public ActionResult removeEvent()
        {
            return View();
        }

        /// <summary>
        /// resourcesBySlot
        /// Get the relevant resources for a given slot.
        /// Parameters
        /// slot Object
        /// Returns
        /// Object The relevant resources.
        /// </summary>
        /// <returns></returns>
        public ActionResult resourcesBySlot()
        {
            return View();
        }

        /// <summary>
        /// saveAsPDF
        /// Initiates the PDF export and returns a promise. Also triggers the pdfExport event.
        /// Calling this method may trip the built-in browser pop-up blocker. To avoid that, call this method as a response to an end-user action, e.g. a button click.
        /// Returns
        /// Promise A promise that will be resolved when the export completes. The same promise is available in the pdfExport event arguments.
        /// </summary>
        /// <returns></returns>
        public ActionResult saveAsPDF()
        {
            return View();
        }

        /// <summary>
        /// saveEvent
        /// Saves the scheduler event which is open in the edit form and closes it.
        /// </summary>
        /// <returns></returns>
        public ActionResult saveEvent()
        {
            return View();
        }

        /// <summary>
        /// select
        /// Gets or sets the events (or slots) which are selected.
        /// Parameters
        /// events Array
        /// The Uids of events which should be selected. List of the available events can be get using the data method.
        /// options Object
        /// options.events Array
        /// The Uids of events which should be selected. List of the available events can be get using the data method.
        /// options.resources Array
        /// The resource values (groups) in which the events or slots should be selected.
        /// options.start Date
        /// The start time from which the selection of the slots begins.
        /// options.end Date
        /// The end time in which the selection of the slots ends.
        /// options.isAllDay Boolean
        /// Allows selection of slots in day and time slots of the view (applicable in day/week/workweek views).
        /// </summary>
        /// <returns></returns>
        public ActionResult select()
        {
            return View();
        }

        /// <summary>
        /// setDataSource
        /// Sets the data source of the widget.
        /// Parameters
        /// dataSource kendo.data.SchedulerDataSource
        /// The data source to which the widget should be bound.
        /// </summary>
        /// <returns></returns>
        public ActionResult setDataSource()
        {
            return View();
        }

        /// <summary>
        /// slotByPosition
        /// Get the time slot from given horizontal (x) and vertical (y) position.
        /// Parameters
        /// xPosition Number
        /// The horizontal position.
        /// yPosition Number
        /// The vertical position.
        /// Returns
        /// Object The time slot.
        /// </summary>
        /// <returns></returns>
        public ActionResult slotByPosition()
        {
            return View();
        }

        /// <summary>
        /// slotByElement
        /// Get the time slot from given element.
        /// Parameters
        /// element Element|jQuery
        /// Returns
        /// Object The time slot.
        /// </summary>
        /// <returns></returns>
        public ActionResult slotByElement()
        {
            return View();
        }

        /// <summary>
        /// view
        /// Gets or sets the current scheduler view.
        /// Parameters
        /// type String (optional)
        /// The view type to select.
        /// Returns
        /// kendo.ui.SchedulerView the current scheduler view.
        /// </summary>
        /// <returns></returns>
        public ActionResult view()
        {
            return View();
        }

        /// <summary>
        /// Fired when a new event is about to be added.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event Object
        /// The event data from which the SchedulerEvent instance will be created and added to the DataSource.
        /// e.preventDefault Function
        /// If invoked prevents the add action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_add_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_add_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// cancel
        /// Fired when the user cancels editing by clicking the "cancel" button.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.container jQuery
        /// The jQuery object representing the container element. That element contains the editing UI.
        /// e.event kendo.data.SchedulerEvent
        /// The event which is no longer in edit mode.
        /// e.preventDefault Function
        /// If invoked prevents the cancel action. The scheduler event remains in edit mode.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_cancel_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_cancel_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// change
        /// Fired when the user selects a cell or event in the scheduler.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.start Date
        /// The selection start date.
        /// e.end Date
        /// The selection end date.
        /// e.events Array
        /// A list of the selected scheduler events.
        /// e.slots Array
        /// A list of the selected slots. Each slot has the following properties:
        /// slot.start - The slot's start date.
        /// slot.end - The slot's end date.
        /// slot.element - The slot's element.
        /// e.resources Object
        /// The resources for the slot if resource grouping is enabled.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_change_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_change_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// dataBinding
        /// Fired before the widget binds to its data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_dataBinding_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBinding_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// dataBound
        /// Fired when the widget is bound to data from its data source.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// Example - subscribe to the "dataBound" event during initialization
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_dataBound_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_dataBound_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// edit
        /// Fired when the user opens a scheduler event in edit mode by or creates a new event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.container jQuery
        /// The jQuery object representing the container element. That element contains the editing UI.
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being edited.
        /// e.preventDefault Function
        /// If invoked prevents the edit action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_edit_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_edit_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// moveStart
        /// Fired when the user starts to drag an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being moved.
        /// e.preventDefault Function
        /// If invoked prevents the move action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_moveStart_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_moveStart_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// move
        /// Fired when the user is moving an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being moved.
        /// e.slot Object
        /// The slot over which the event is currently positioned.
        /// e.slot.element jQuery
        /// The slot's element.
        /// e.slot.start Date
        /// The slot's start date.
        /// e.slot.end Date
        /// The slot's end date.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_move_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_move_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// moveEnd
        /// Fired when the user stops moving an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.start Date
        /// The start date of the dragged range.
        /// e.end Date
        /// The end date of the dragged range.
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being moved.
        /// e.slot Object
        /// The slot over which the event is currently positioned.
        /// e.slot.element jQuery
        /// The slot's element.
        /// e.slot.start Date
        /// The slot's start date.
        /// e.slot.end Date
        /// The slot's end date.
        /// e.preventDefault Function
        /// If invoked prevents the move action.
        /// e.resources Object
        /// The resources for the slot if resource grouping is enabled.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_moveEnd_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_moveEnd_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// navigate
        /// Fired when the user changes the selected date, or view of the scheduler
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.action String
        /// Name of the action. Possible values are:
        /// changeView - navigate to different view
        /// next - navigate to next time period
        /// previous - navigate to previous time period
        /// today - select today's date
        /// changeDate - a date is selected via the Calendar
        /// e.date Date
        /// Selected date
        /// e.view String
        /// Name of the view
        /// e.preventDefault Function
        /// If invoked prevents the action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_navigate_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_navigate_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// pdfExport
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// Event Data
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// e.preventDefault Function
        /// If invoked the scheduler will not save the generated file.
        /// e.promise Promise
        /// A promise that will be resolved when the export completes.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_pdfExport_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_pdfExport_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Fired when the user clicks the "destroy" button.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being removed.
        /// e.preventDefault Function
        /// If invoked prevents the remove action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_remove_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_remove_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// resizeStart
        /// Fired when the user starts to resize an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being resized.
        /// e.preventDefault Function
        /// If invoked prevents the resize action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_resizeStart_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_resizeStart_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// resize
        /// Fired when the user is resizing an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being resized.
        /// e.slot Object
        /// The slot over which the event is resized to.
        /// e.slot.element jQuery
        /// The slot's element.
        /// e.slot.start Date
        /// The slot's start date.
        /// e.slot.end Date
        /// The slot's end date.
        /// e.preventDefault Function
        /// If invoked prevents the resize action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_resize_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_resize_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// resizeEnd
        /// Fired when the user releases the mouse after resizing an event.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.event kendo.data.SchedulerEvent
        /// The event which is being resized.
        /// e.slot Object
        /// The slot over which the event is resized to.
        /// e.slot.element jQuery
        /// The slot's element.
        /// e.slot.start Date
        /// The slot's start date.
        /// e.slot.end Date
        /// The slot's end date.
        /// e.preventDefault Function
        /// If invoked prevents the resize action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_resizeEnd_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_resizeEnd_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// save
        /// Fired when the user saves a scheduler event by clicking the "save" button.
        /// The event handler function context (available via the this keyword) will be set to the widget instance.
        /// Event Data
        /// e.container jQuery
        /// The jQuery object representing the container element. That element contains the editing UI.
        /// e.event kendo.data.SchedulerEvent
        /// The event which is saved.
        /// e.preventDefault Function
        /// If invoked prevents the save action.
        /// e.sender kendo.ui.Scheduler
        /// The widget instance which fired the event.     
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_save_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_save_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to add Kendo UI controls to a custom event editor.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_controls_to_a_custom_editor()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to clone events on Ctrl + Move
        /// </summary>
        /// <returns></returns>
        public ActionResult Clone_events_on_Ctrl_plus_Move()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create and use custom templates for the Kendo UI Scheduler events and edit window.
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_edit_and_event_templates()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to implement custom editing in Agenda view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_editing_in_Agenda_view()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to create custom restriction for Scheduler events.
        /// </summary>
        /// <returns></returns>
        public ActionResult Custom_restriction()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to calculate widgets height dynamically.
        /// </summary>
        /// <returns></returns>
        public ActionResult Dynamic_calculation_of_the_widget_height()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to calculate widgets height dynamically in mobile.
        /// </summary>
        /// <returns></returns>
        public ActionResult Dynamic_calculation_of_the_widget_height_in_mobile()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to edit an event using touchend on mobile devices.
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit_records_on_touchend_event()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to edit Scheduler event using ContextMenu
        /// </summary>
        /// <returns></returns>
        public ActionResult Editing_using_ContextMenu()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how create an external editor form
        /// </summary>
        /// <returns></returns>
        public ActionResult External_editor_form()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to get next occurance of Kendo UI SchedulerEvent
        /// </summary>
        /// <returns></returns>
        public ActionResult Get_next_occurance()
        {
            return View();
        }

        /// <summary>
        /// Getting reference to the built-in Validator
        /// The example below demonstrates how to get a reference to the built-in Kendo UI Validator using the edit event of the widget.
        /// </summary>
        /// <returns></returns>
        public ActionResult Getting_reference_to_the_built_in_Validator()
        {
            return View();
        }

        /// <summary>
        /// Hide edit buttons
        /// The example below demonstrates how to hide the edit buttons in a Kendo UI Scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult Hide_edit_buttons()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to hide header and footer when Scheduler is used in adaptive rendering
        /// </summary>
        /// <returns></returns>
        public ActionResult Hide_header_and_footer_adaptive_rendering()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to hide the time headers of a ungrouped scheduler view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Hide_times_header_of_a_ungrouped_view()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to hide the time headers of a grouped scheduler view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Hide_times_header_of_a_grouped_view()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to extract Scheduler events to .ical file
        /// </summary>
        /// <returns></returns>
        public ActionResult iCal_export()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to use the databound event to modify the event styling.
        /// </summary>
        /// <returns></returns>
        public ActionResult Modify_event_styling_on_databound()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to setup widget to work offline. For more details refer to the "Work offline" help topic.
        /// </summary>
        /// <returns></returns>
        public ActionResult Work_offline_with_the_Kendo_UI_Scheduler()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to persist the event resouces on move.
        /// </summary>
        /// <returns></returns>
        public ActionResult Persist_the_resource_values_on_event_move()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how create a recurrence editor using mobile editor approach.
        /// </summary>
        /// <returns></returns>
        public ActionResult Recurrence_editor_using_mobile_editor()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to use remote validation during event editing.
        /// </summary>
        /// <returns></returns>
        public ActionResult Use_remote_validation()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to set different start week day
        /// </summary>
        /// <returns></returns>
        public ActionResult Set_different_start_week_day()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to set the event color in the template.
        /// </summary>
        /// <returns></returns>
        public ActionResult Set_event_color_in_the_template()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to increase the height of the cells to show more events
        /// </summary>
        /// <returns></returns>
        public ActionResult Show_more_events_in_the_view_cells()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to show only all day events in the Scheduler.
        /// </summary>
        /// <returns></returns>
        public ActionResult Show_only_all_day_events()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to update the opposite start/end picker value on model change
        /// </summary>
        /// <returns></returns>
        public ActionResult Update_the_opposite_picker_value_on_model_change()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to use different date formats for the Scheduler events.
        /// </summary>
        /// <returns></returns>
        public ActionResult Using_different_date_formats()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to bind the widget to a local observableObject and change properties at run time.
        /// </summary>
        /// <returns></returns>
        public ActionResult Using_local_observable_data_object()
        {
            return View();
        }



             






    }
}