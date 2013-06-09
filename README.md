# Zeta Resource Editor
Edit your .NET resource files in parallel

*[Download latest binary setup package](http://zeta.li/zre-download-setup)* | [Download latest sources](http://zeta.li/zre-download-sources) | [Visit official website](http://www.zeta-resource-editor.com) | [Support forum](http://groups.google.com/group/zeta-resource-editor)

![Alt text](http://i.imgur.com/dYMVWKn.png)

*[Download latest binary setup package](http://zeta.li/zre-download-setup)* | [Download latest sources](http://zeta.li/zre-download-sources) 

_(Please see the bottom of this article for the latest updates)_
_(The project is also available at [The Code Project](http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx), at [CodePlex](https://zetaresourceeditor.codeplex.com) and at [Google Code](http://code.google.com/p/zetaresourceeditor))_

## Introduction

This is a small utility application that enables you to edit *string* resources from multiple different resource files together inside one single data grid.

## Background

When translating the resources of a .NET application into other languages, the biggest and most difficult task for me was to translate string resources:

The [recommended way](http://msdn2.microsoft.com/en-us/library/8bxdx003.aspx) (at least what I know) is to create one single .RESX file for every language you want the strings to be translated to. I.e. one "Resources.resx" for neutral/English, one "Resources.de.resx" for German, one "Resources.fr.resx" for French, etc.

Since I had to duplicate the resource keys into each RESX file, I often did not manage to keep the resource keys synchronal among all RESX files.

This is where the idea for this tool came up: Take all RESX files, merge their resource _keys_ and display the resource _values_ side by side in one editable data grid.

## How to use the tool (simple version)

### 1.) Create your resource files in Visual Studio .NET 2005 as you usually do
Add a resource file for each language you want to support and place them in the "Properties" folder of your project.

Keep the naming schema "Resources.<language>.resx", e.g. "Resources.fr-ch.resx" for Swiss with French language. The following screenshot is an example for English and German.

![Alt text](http://i.imgur.com/deK562L.png)

_English and German language resources_

### 2.) Start Zeta Resource Editor and open the resource files
Next, simply start Zeta Resource Editor and open the files you want to edit in parallel.

![Alt text](http://i.imgur.com/xZHL7ml.png)

_Opening two resource files and load them into Zeta Resource Editor_

### 3.) Edit the resources and save them

![Alt text](http://i.imgur.com/5ij2Dly.png)

_The main window of Zeta Resource Editor_

You could either edit the cells in the grid directly by selecting and pressing F2 or, for a better overview, select a cell in the grid and then edit the details in the details view at the bottom of the window.

### 4.) Save and compile

Finally save the resources in Zeta Resource Editor and compile your solution inside Visual Studio .NET 2005/2008.

## How to use the tool (enhanced version with projects)

Starting march 2008, I added the concept of "projects". Projects are XML files with the ".zreproj" file extension that store 1..n so called "file groups" of RESX files that you want to edit together.

The idea is that you usually have a Visual Studio .NET solution that has multiple projects with multiple RESX files. Instead of opening them one by one inside Zeta Resource Editor, you once create a project inside Zeta Resource Editor and all the resources files you want to edit.

Later you simple open the Zeta Resource Editor project and double click the individual files to edit them.

To use projects, simply select *Create New Project* from the *Projects* main menu.

![Alt text](http://i.imgur.com/iPuLymO.png)

_Dialog to create a new project_

Once you have created a new project, it is being displayed in the main window on the left side. Right click the root node and select *Add file group to project* to add a new file group with multiple RESX files to the project:

![Alt text](http://i.imgur.com/tO71eF0.png)

_Right-clicking the project to add files_

Then select the apropriate files and they will appear in the project list:

![Alt text](http://i.imgur.com/ODmCY7o.png)

_Project list with one added file group with two individual files_

Simply double click the file group to edit the files inside the grid in Zeta Resource Editor.

## Epilog

### Other Tools

I must admit that I am not an expert regarding translation/localization/globalization tools.

Doing lots of Internet searches, trying different tools, all of them seems to do their own kind of hand algorithms and behaviors.

But what I wanted was to do it _my way_, respectively the way that Visual Studio .NET 2005 does it.

So I do hope my approach isn't that naive but rather a small pragmatic tool to aid me (and hopefully others) managing the hassles of translating string resources.

If you do know other tools, preferably free ones, that do the same or even better than this one I presented you here, please post the hyperlinks below in the comments section!

Some tools and resources I found to be rather good are:

  * "[Resources and Localization Using the .NET Framework SDK](http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cptutorials/html/resources_and_localization_using_the__net_framework_sdk.asp)", MSDN library
  * "[Multi-Language Add-In for Visual Studio .NET](http://www.jollans.com/)", nice, inexpensive tool for translating right inside Visual Studio .NET
  * [Sisulizer](http://www.sisulizer.com/), translator tool that works on the compiled binary files

### The current state of the Tool

Beside small test applications, we did not use the tool extensively.

We developed this tool for the upcoming releases of our applications [Zeta Producer](http://www.zeta-producer.com/) version 8 (a windows-based Content Management System) and [Zeta Uploader](http://www.zeta-uploader.com/) (a tool for sending large files by e-mail).

Although I think it is ready-to-use, the main reason why I already released it was to give other developers the chance to use it and to provide a lot of feedback to me for improving the application.

So please keep the feedback coming :-)!

### Planed enhancements

  * Work on a more content-based way instead of a file-based way. E.g. allow for editing/exporting/importing all resources from all files of a project within one single grid/Excel document.
  * Add tagging to simplify the finding of resources across multiple resource files.
  * Support other resource files beside the .NET resx files.
  * _Your suggestions here._

## History

  * **2013-06-09** - Changed Excel reading/writing functions to use [free Excel library](https://code.google.com/p/excellibrary/).
  * **2013-06-07** - First release to Github. The project is also available at [The Code Project](http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx), at [CodePlex](https://zetaresourceeditor.codeplex.com) and at [Google Code](https://code.google.com/p/zetaresourceeditor/). Please note that a valid purchased license of DevExpress is required to build the tool.
  * **2012-02-22** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Small fix to allow translation even when no project is loaded.
  * **2011-10-10** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Fixed an issue when automatically adding resource files from a Visual Studio .NET Solution.
  * **2011-08-02** - There is now a support forum for [Zeta Resource Editor](http://groups.google.com/group/zeta-resource-editor).
  * **2011-06-15** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Fixed an issue when adding new resources and letting them automatically translate. Optimized away some more pixels in the main window to have more height.
  * **2011-05-14** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. The Excel export wizard now allows to directly send exported files to one or multiple e-mail receivers. This is done through our free [Zeta Uploader service](https://www.zeta-uploader.com).
  * **2011-03-24** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Added missing VC 10.0 CRT DLLs to setup package. This fixes errors on some machines where the Excel export failed with SQLite-related error message.
  * **2011-03-14** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Fixed an issue with translation through Bing Translator with unsupported languages.
  * **2011-03-06** - Updated the [binary setup](http://zeta.li/zre-download-setup) and the source download. Added a right-click grid context menu item to delete the contents of a row for selected language.
  * **2011-01-30** - Modified the [binary setup](http://zeta.li/zre-download-setup) and the source code. Added:
      * Added a replace function to find and replace texts in a grid. 
      * Added project folders properties to exclude project folders and file groups from being exported/imported. 
      * Improved speed of translating a large number of texts. 
      * Added a "Don't translate" word list to protect words from being translated. 
      * The dialog window to create new resource files now has the ability to add files for multiple languages in one operation. 
      * Various bugs were fixed. [Homepage erstellen](http://www.zeta-producer.com/de/homepage-erstellen.html)
  * **2011-01-06** - Modified the [binary setup](http://zeta.li/zre-download-setup) and the source code. Added Danish as an additional language of the GUI.
  * **2010-02-24** - Modified the [binary setup](http://zeta.li/zre-download-setup) and the source code. Added support for configuring an HTTP proxy server for all outgoing HTTP requests like e.g. the translation service.
  * **2010-02-21** - Modified the [ binary setup](http://zeta.li/zre-download-setup) and the source code. It is now possible to edit not just one file group inside the grid but also multiple file groups at once. Simply double-click on the project or a project folder in the tree. _(This feature is currently in Beta stage; your feedback is very welcome!)_ ![Alt text](http://i.imgur.com/Pfzs4v8.png).
  * **2010-02-14** - Modified the [ binary setup](http://zeta.li/zre-download-setup) and the source code. Added the suggestions of  [this comment](http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3351995#xx3351995xx).
  * **2010-01-15** - Modified the [ binary setup](http://zeta.li/zre-download-setup) and the source code. Added ability to display the comments of the first resource file in the editor grid (read and write). Activate this option in the project settings Fixed issues with automatic translations. All changes were done by user "[TheMegaLoser](http://www.codeproject.com/Messages/3332703/Re-Updated-source-code-translation.aspx)".
  * **2010-01-14** - Updated the source download to match the latest [ binary setup](http://zeta.li/zre-download-setup).
  * **2010-01-04** - Modified the [ binary setup](http://zeta.li/zre-download-setup), enhanced the Excel export and import to make it more usable for external translators/translations. See my [weblog article](http://blog.magerquark.de/archive/1001403) for details and a screenshot.
  * **2009-10-31** - Minor modifications to the [ binary setup](http://zeta.li/zre-download-setup). As of request, I updated the source code download. Please note that you need to have an installed license of the DevExpress WinForms components in order to successfully compile the sources.
  * **2009-08-25** - Updated the [ binary setup](http://zeta.li/zre-download-setup) again. Rewrote the language detection routine that detects a language from a file name. Now configurable through the project settings. Added function "Create new files" to create missing resource files for a complete project (or a project folder) with just a few clicks.
  * **2009-08-08** - Updated the [ binary setup](http://zeta.li/zre-download-setup) again.  Added the long-requested (including by myself!) ability to create new files from within Zeta Resource Editor: ![Alt text](http://i.imgur.com/fpVjjKi.png) This is done by copying from an existing file and replacing all the existing texts. Also included serveral minor bug fixes. Added the ability to show/hide the complete project tree panel (the left part of the main window) for better screen usage on smaller monitors.
  * **2009-07-12** - Updated the [ binary setup](http://zeta.li/zre-download-setup) again. Introduced what I call "Project Folders" - virtual folders that enables you to organize larger numbers of file groups into separate units to keep the project manageable. Also added move (up/down) and drag and drop to the tree.
  * **2009-07-04** - Updated the [ binary setup](http://zeta.li/zre-download-setup) again. Also updated the source download. Changes: Fixed reported bugs. Added first version of Microsoft Office Excel export and import (Your feedback is _very_ welcome).
  * **2009-06-27** - Updated the [ binary setup](http://zeta.li/zre-download-setup) and fixed several bugs reported directly to me and below here in the forum. Added keyboard shortcuts to work again. Unfortunately the previous version broke the update mechanism, so you will get an error when clicking the "Update available" button. Sorry for that, I fixed it now.
  * **2009-06-18** - Updated the [ binary setup](http://zeta.li/zre-download-setup). Changes:
      * This version is primarily a complete rewrite of the GUI. I hope you like it! I throw out all standard Windows Forms components and used the GUI components of DevExpress. The main reason for the rewrite was to have a strong foundation for doing more complex UI stuff (like grid filtering, exporting) in the future.
      * Changed the main window to use ribbons.
      * Added modern Windows Vista compatible icons.
      * Added a news area to the main windows. You can turn this of in the application's options dialog window.
      * Added some initial spell checking functionality (configurable in the project settings) with support of OpenOffice dictionaries.
      * Complete empty lines can now be hidden from the grid.
      * Added an option to configure the behaviour [ reported by "nkstr"](http://www.codeproject.com/Messages/3059682/Bug-Designer-files-seem-to-hide-resource-files-from-the-tree-view.aspx)
  * **2009-04-26** - Updated the [ binary setup](http://zeta.li/zre-download-setup). Changes: Integrated Google Translation API calls to automatically translate from one language to another language (See the "Edit" main menu). Also included is a general-purpose translation window. Did some rather simple, but hopefully useful [ introduction screencasts](http://zeta-sw.com/zre/#screencasts)
  * **2009-03-31** - ![Alt text](http://i.imgur.com/ljzQDON.png). Updated the [binary setup](http://zeta.li/zre-download-setup) again. Changes: The state of a translated file group is now shown both in the tree view as well as in the upper left corner of the editing grid.
  * **2009-02-08** - Updated the [ binary setup](http://zeta.li/zre-download-setup) again. Changes: Adjusted the display of file groups in the left tree. Enhanced and corrected the coloring in the grid. New color gray to show completely empty rows among all languages.
  * **2009-02-08** - Updated the [ binary setup](http://zeta.li/zre-download-setup). Again some minor fixes in how the settings are stored. Added a German translation for the whole GUI, which is automatically chosen if you are on a German OS. Added project option for not storing empty resource strings (useful for fall back to the default language)
  * **2008-12-29** - Updated the [ binary setup](http://zeta.li/zre-download-setup). Some minor fixes, adjustments of the generated group names and a neat little function to import a complete folder tree with all its resource files with one single operation.
