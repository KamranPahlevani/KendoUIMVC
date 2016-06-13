using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC.Controllers
{
    public class Kendo_UI_ToolBarController : Controller
    {
        // GET: Kendo_UI_ToolBar

        /// <summary>
        /// resizable Boolean (default: true)
        /// If resizable is set to true the widget will detect changes in the viewport width and hides the overflowing controls in the command overflow popup.
        /// </summary>
        /// <returns></returns>
        public ActionResult resizable()
        {
            return View();
        }

        /// <summary>
        /// items Array
        /// A JavaScript array that contains the ToolBar's commands configuration.
        /// For more information regarding supported commands and their configuration properties check the Getting Started topic.
        /// </summary>
        /// <returns></returns>
        public ActionResult items()
        {
            return View();
        }

        /// <summary>
        /// items.attributes Object
        /// Specifies the HTML attributes of a ToolBar button.
        /// HTML attributes which are JavaScript keywords (e.g. class) must be quoted.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_attributes()
        {
            return View();
        }

        /// <summary>
        /// items.buttons Array
        /// Specifies the buttons of ButtonGroup.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.attributes Object
        /// Specifies the HTML attributes of a ButtonGroup's button.
        /// HTML attributes which are JavaScript keywords (e.g. class) must be quoted.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_attributes()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.click Function
        /// Specifies the click event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_click()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.enable Boolean (default: true)
        /// Specifies whether the button is initially enabled or disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_enable()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.group String
        /// Assigns the button to a group. Applicable only for the children of a ButtonGroup that has togglable true.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_group()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.icon String
        /// Sets icon for the menu button. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_icon()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.id String
        /// Specifies the ID of the button.
        /// By design the widget will render two buttons - the one located in the ToolBar container will receive the specified ID,
        /// the one located in the Overflow Popup container will receive the specified ID but with *_overflow* suffix.
        /// If the ID will be used for determining which button is clicked in the click or toggle event handler,
        /// the developer should use the ID property of the event data which always contains the specified ID without suffix.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_id()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.imageUrl String
        /// If set, the ToolBar will render an image with the specified URL in the button.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_imageUrl()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.selected Boolean (default: false)
        /// Specifies if the toggle button is initially selected. Applicable only for the children of a ButtonGroup that has togglable true.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_selected()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.showIcon String (default: "both")
        /// Specifies where the icon of the button will be displayed. Applicable only for the children of a ButtonGroup
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_showIcon()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.showText String (default: "both")
        /// Specifies where the text of the menu button will be displayed. Applicable only for the buttons of a ButtonGroup.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_showText()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.spriteCssClass String
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for button icon.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_spriteCssClass()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.toggle Function
        /// Specifies the toggle event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_toggle()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.togglable Boolean
        /// Specifies if the button is togglable, e.g. has a selected and unselected state. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_togglable()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.text String
        /// Specifies the text of the menu button.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_text()
        {
            return View();
        }

        /// <summary>
        /// items.buttons.url String
        /// Specifies the url of the button to navigate to.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_buttons_url()
        {
            return View();
        }

        /// <summary>
        /// items.click Function
        /// Specifies the click event handler of the button. Applicable only for commands of type button and splitButton.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_click()
        {
            return View();
        }

        /// <summary>
        /// items.enable Boolean (default: true)
        /// Specifies whether the control is initially enabled or disabled. Default value is "true".
        /// </summary>
        /// <returns></returns>
        public ActionResult items_enable()
        {
            return View();
        }

        /// <summary>
        /// items.group String
        /// Assigns the button to a group. Applicable only for buttons with togglable: true.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_group()
        {
            return View();
        }

        /// <summary>
        /// items.icon String
        /// Sets icon for the item. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_icon()
        {
            return View();
        }

        /// <summary>
        /// items.id String
        /// Specifies the ID of the button.
        /// By design the widget will render two buttons - the one located in the ToolBar container will receive the specified ID,
        /// the one located in the Overflow Popup container will receive the specified ID but with *_overflow* suffix.
        /// If the ID will be used for determining which button is clicked in the click or toggle event handler,
        /// the developer should use the ID property of the event data which always contains the specified ID without suffix.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_id()
        {
            return View();
        }

        /// <summary>
        /// items.imageUrl String
        /// If set, the ToolBar will render an image with the specified URL in the button.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_imageUrl()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons Array
        /// Specifies the menu buttons of a SplitButton.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.attributes Object
        /// Specifies the HTML attributes of a menu button.
        /// HTML attributes which are JavaScript keywords (e.g. class) must be quoted.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_attributes()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.enable Boolean
        /// Specifies whether the menu button is initially enabled or disabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_enable()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.icon String
        /// Sets icon for the menu buttons. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_icon()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.id String
        /// Specifies the ID of the menu buttons.
        /// By design the widget will render two buttons - the one located in the ToolBar container will receive the specified ID,
        /// the one located in the Overflow Popup container will receive the specified ID but with *_overflow* suffix.
        /// If the ID will be used for determining which button is clicked in the click or toggle event handler,
        /// the developer should use the ID property of the event data which always contains the specified ID without suffix.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_id()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.imageUrl String
        /// If set, the ToolBar will render an image with the specified URL in the menu button.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_imageUrl()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.spriteCssClass String
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for menu button icon.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_spriteCssClass()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.text String
        /// Specifies the text of the menu buttons.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_text()
        {
            return View();
        }

        /// <summary>
        /// items.menuButtons.url String
        /// Specifies the url of the menu button to navigate to.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_menuButtons_url()
        {
            return View();
        }

        /// <summary>
        /// items.overflow String (default: "auto")
        /// Specifies how the button behaves when the ToolBar is resized. Possible values are: "always", "never" or "auto" (default).
        /// </summary>
        /// <returns></returns>
        public ActionResult items_overflow()
        {
            return View();
        }

        /// <summary>
        /// items.overflowTemplate String|Function
        /// Specifies what element will be added in the command overflow popup. Applicable only for items that have a template.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_overflowTemplate()
        {
            return View();
        }

        /// <summary>
        /// items.primary Boolean (default: false)
        /// Specifies whether the button is primary. Primary buttons receive different styling.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_primary()
        {
            return View();
        }

        /// <summary>
        /// items.selected Boolean (default: false)
        /// Specifies if the toggle button is initially selected. Applicable only for buttons with togglable: true.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_selected()
        {
            return View();
        }

        /// <summary>
        /// items.showIcon String (default: "both")
        /// Specifies where the button icon will be displayed. Possible values are: "toolbar", "overflow" or "both" (default).
        /// </summary>
        /// <returns></returns>
        public ActionResult items_showIcon()
        {
            return View();
        }

        /// <summary>
        /// items.showText String (default: "both")
        /// Specifies where the text will be displayed. Possible values are: "toolbar", "overflow" or "both" (default).
        /// </summary>
        /// <returns></returns>
        public ActionResult items_showText()
        {
            return View();
        }

        /// <summary>
        /// items.spriteCssClass String
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for button icon.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_spriteCssClass()
        {
            return View();
        }

        /// <summary>
        /// items.template String|Function
        /// Specifies what element will be added in the ToolBar wrapper. Items with template does not have a type.
        /// If overflowTemplate is not defined for a template command, than the command will be threated as overflow: "never".
        /// </summary>
        /// <returns></returns>
        public ActionResult items_template()
        {
            return View();
        }

        /// <summary>
        /// items.text String
        /// Sets the text of the button.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_text()
        {
            return View();
        }

        /// <summary>
        /// items.togglable Boolean (default: false)
        /// pecifies if the button is togglable, e.g. has a selected and unselected state.
        /// Buttons with togglable: true will fire the toggle event. click event will not be fired.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_togglable()
        {
            return View();
        }

        /// <summary>
        /// items.toggle Function
        /// Specifies the toggle event handler of the button. Applicable only for commands of type button and togglable: true.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_toggle()
        {
            return View();
        }

        /// <summary>
        /// items.type String
        /// Specifies the command type. Supported types are "button", "splitButton", "buttonGroup", "separator".
        /// Specifying the type is mandatory. Only commands that have a template does not need type.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_type()
        {
            return View();
        }

        /// <summary>
        /// items.url String
        /// Specifies the url to navigate to.
        /// </summary>
        /// <returns></returns>
        public ActionResult items_url()
        {
            return View();
        }

        /// <summary>
        /// add
        /// Adds new command to the ToolBar widget. Accepts object with valid command configuration options.
        /// Parameters
        /// command Object
        /// An object with valid command configuration options.
        /// </summary>
        /// <returns></returns>
        public ActionResult add()
        {
            return View();
        }

        /// <summary>
        /// destroy
        /// Prepares the widget for safe removal from DOM. Detaches all event handlers and removes jQuery.data attributes to avoid memory leaks.
        /// Calls destroy method of any child Kendo widgets.
        /// This method does not remove the widget element from DOM.
        /// </summary>
        /// <returns></returns>
        public ActionResult destroy()
        {
            return View();
        }

        /// <summary>
        /// enable
        /// Enables or disables the specified command. If the second parameter is omitted it will be treated as true and the command will be enabled.
        /// Parameters
        /// command String|Element|jQuery
        /// A string, DOM element or jQuery object which represents the command to be enabled or disabled. A string is treated as jQuery selector.
        /// enable Boolean
        /// A boolean flag that determines whether the command should be enabled (true) or disabled (false). If omitted the command will be enabled.
        /// </summary>
        /// <returns></returns>
        public ActionResult enable_command()
        {
            return View();
        }

        public ActionResult disable_command()
        {
            return View();
        }

        /// <summary>
        /// getSelectedFromGroup
        /// Returns the selected toggle button from the specified group.
        /// Parameters
        /// groupName String
        /// The name of the group.
        /// </summary>
        /// <returns></returns>
        public ActionResult getSelectedFromGroup()
        {
            return View();
        }

        /// <summary>
        /// remove
        /// Removes a command from the ToolBar widget. The command is removed from the ToolBar container and overflow popup (if resizable is enabled).
        /// Parameters
        /// command String|Element|jQuery
        /// A string, DOM element or jQuery object which represents the command to be removed. A string is treated as jQuery selector.
        /// </summary>
        /// <returns></returns>
        public ActionResult remove()
        {
            return View();
        }

        /// <summary>
        /// toggle
        /// Change the state of a togglable button.
        /// This method does not trigger the toggle event!
        /// </summary>
        /// <returns></returns>
        public ActionResult toggle()
        {
            return View();
        }

        /// <summary>
        /// click
        /// Fires when the user clicks a command button.
        /// The event does not fire for togglable buttons. If the button has togglable: true use the toggle event.
        /// Event Data
        /// e.target jQuery
        /// The jQuery object that represents the command element.
        /// e.id String
        /// The id of the command element.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_click_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_click_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// close
        /// Fires when the SplitButton's popup closes.
        /// Event Data
        /// e.SplitButton jQuery
        /// The jQuery object that represents the SplitButton element.
        /// e.preventDefault Function
        /// Prevents the close action if called. The popup will remain open.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_close_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_close_event_after_initialization_and_prevent_the_popup_closing()
        {
            return View();
        }

        /// <summary>
        /// open
        /// Fires when the Split Button's popup opens.
        /// Event Data
        /// e.SplitButton jQuery
        /// The jQuery object that represents the SplitButton element.
        /// e.preventDefault Function
        /// Prevents the open action if called. The popup will remain closed.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_open_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_open_event_after_initialization_and_prevent_the_popup_closing()
        {
            return View();
        }

        /// <summary>
        /// toggle
        /// Fires when the user changes the checked state of a toggle button.
        /// Important click event does not fire for buttons that have togglable: true
        /// Event Data
        /// e.target jQuery
        /// The jQuery object that represents the command element.
        /// e.checked Boolean
        /// Boolean flag that indicates the button state.
        /// e.id String
        /// The id of the command element.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_toggle_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_toggle_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// overflowClose
        /// Fires when the overflow popup container is about to close.
        /// Event Data
        /// e.preventDefault Function
        /// Prevents the close action if called. The popup will remain open.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_overflowClose_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_overflowClose_event_after_initialization()
        {
            return View();
        }

        /// <summary>
        /// overflowOpen
        /// Fires when the overflow popup container is about to open.
        /// Event Data
        /// e.preventDefault Function
        /// Prevents the close action if called. The popup will remain closed.
        /// e.sender kendo.ui.ToolBar
        /// The widget instance which fired the event.
        /// </summary>
        /// <returns></returns>
        public ActionResult subscribe_to_the_overflowOpen_event_during_initialization()
        {
            return View();
        }

        public ActionResult subscribe_to_the_overflowOpen_event_after_initialization()
        {
            return View();
        }



    }
}