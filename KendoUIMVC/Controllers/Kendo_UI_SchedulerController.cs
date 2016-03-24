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







    }
}