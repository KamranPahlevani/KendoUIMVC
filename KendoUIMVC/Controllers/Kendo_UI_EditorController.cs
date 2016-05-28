using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendo.Controllers
{
    public class Kendo_UI_EditorController : Controller
    {
        //
        // GET: /Kendo_UI_Editor/

        /// <summary>
        /// Indicates whether the Editor should submit encoded HTML tags.
        /// </summary>
        /// <returns></returns>
        public ActionResult encoded()
        {
            return View();
        }

        /// <summary>
        /// Defines the text of the labels that are shown within the editor.
        /// Used primarily for localization.
        /// </summary>
        /// <returns></returns>
        public ActionResult messages()
        {
            return View();
        }

        /// <summary>
        /// Allows custom stylesheets to be included within the editing area.
        /// </summary>
        /// <returns></returns>
        public ActionResult stylesheets()
        {
            return View();
        }

        /// <summary>
        /// tools.name String
        ///The mandatory name of the tool. The built-in tools are "bold", "italic", "underline", "strikethrough", "fontName", "fontSize", "foreColor", "backColor", "justifyLeft", "justifyCenter", "justifyRight", "justifyFull", "insertUnorderedList", "insertOrderedList", "indent", "outdent", "formatBlock", "createLink", "unlink", "insertImage", "insertHtml", "viewHtml".
        ///tools.tooltip String
        ///The text which will be displayed when the end-user hovers the tool button with the mouse.
        ///tools.exec Function
        ///The JavaScript function which will be executed when the end-user clicks the tool button.
        ///tools.items Array
        ///For tools that display a list of items (fontName, fontSize, formatBlock), this option specifies the items in the shown list.
        ///tools.items.text String
        ///The string that the popup item will show.
        ///tools.items.value String
        ///The value that will be applied by the tool when this item is selected.
        ///tools.template String
        ///The kendo template that will be used for rendering the given tool.
        /// </summary>
        /// <returns></returns>
        public ActionResult tools()
        {
            return View();
        }

        /// <summary>
        /// Configuration for image browser dialog.
        /// imageBrowser.fileTypes String (default: ".png,.gif,.jpg,.jpeg")
        ///Defines the allowed file extensions.
        ///imageBrowser.path String (default: "/")
        ///Defines the initial folder to display, relative to the root.
        ///imageBrowser.transport Object
        ///Specifies the settings for loading and saving data.
        ///imageBrowser.transport.read Object|String
        ///Options or URL for remote image retrieval.
        ///Important: The value of transport.remote is passed to jQuery.ajax.
        /// </summary>
        /// <returns></returns>
        public ActionResult imageBrowser()
        {
            return View();
        }

        /// <summary>
        /// The example below demonstrates how to define custom kendo validators to check the length of the text content, or the length of the HTML content.
        /// </summary>
        public ActionResult Add_max_length_validation()
        {
            return View();
        }

        /// <summary>
        /// By default the "Insert Image" tool opens a simple dialog which allows the user to type in or paste the URL of an image and optionally specify a tooltip.
        /// Since the Q3 2012 release KendoUI Editor widget supports a new way of picking an image by browsing a list of predefined files and directories. Uploading new images is also supported.
        /// The image browser needs a server side implementation to retrieve and upload the files and directories.
        /// The image browser tool can be configured through the imagebrowser configuration option.
        /// The default requests and responses for the create / read / destroy / upload operations are as follows:
        /// create - makes a request for the creation of a directory with the following parameters: Does not expect a response.
        /// read - sends the path parameter to specify the path which is browsed. Expects a file listing in the following format: Where name is the file or directory name, type is either "f" for file or "d" for directory, and size is the file size (optional).
        /// destroy - makes a request with the following parameters
        /// name - the file / directory to be deleted
        /// path - the directory in which the file / directory resides
        /// type - whether a file or a directory is to be deleted ("f" or "d")
        /// size - optional, the file size, as provided from the read response
        /// upload - makes a request to the uploadUrl. The request payload consists of the uploaded file. Expects a file object in response: All of these can be changed through the imagebrowser configuration.
        /// </summary>
        /// <returns></returns>
        public ActionResult Configuring_the_ImageBrowser()
        {
            return View();
        }

        /// <summary>
        /// Post-processing the editor value before sending it to the server
        /// </summary>
        /// <returns></returns>
        public ActionResult remove_all_paragraphs_before_posting_to_server()
        {
            return View();
        }

        /// <summary>
        /// In order to set the editor selection, you need to create a Range object that specifies the desired selection, and pass it to the selectRange method
        /// </summary>
        /// <returns></returns>
        public ActionResult Set_the_editor_selection()
        {
            return View();
        }

    }
}
