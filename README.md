## 1. Min frisör ASP.NET

Detta är en webbapplikation som hjälper kunder att boka frisörtider, kunna registrera sig, logga in och främst kunna se nyheter och adminstrera inlägg i webbplatsen. <br />
**Intränatapplikation har 8 funktioner:** <br />
1 - se nyheterna som inlägg. <br>
2 - Administrera nyheter, att kunna lägga till/ändra/radera nyheter(för administratörer). <br />
3 - Funktionalitet att kunna boka frisörtider och kunna se dessa tider. <br>
4 - Kunden kan kontakta webbplatsens administratör. <br />
5 - Se kurser och kunna se affärens priser. <br />
6 - Registrera sig och logga in (för administratörer).<br />
Webbapplikationen är responsivt.<br />
**Den här webbapplikationen består av dessa länkar:** <br />
1 - Startsida<br />
2 - Priser <br />
3 - Boka tid <br />
4 - Frisörutbildning <br />
5 - Kontakta oss <br />
6 - Om oss <br />
7 - Logga in <br />
8 - Registrera sig <br />

## 1.2 Mappstruktur <br>

Areas/ <br />
Areas/IdentityHostingStartup.cs <br />
Areas/Identity/ <br />
Areas/Identity/Pages/ <br />
Areas/Identity/Pages/Error.cshtml <br />
Areas/Identity/Pages/Error.cshtml.cs <br />
Areas/Identity/Pages/_ValidationScriptsPartial.cshtml <br />
Areas/Identity/Pages/_ViewImports.cshtml <br />
Areas/Identity/Pages/_ViewStart.cshtml <br />
Areas/Identity/Pages/Account/ <br />
Areas/Identity/Pages/Account/Login.cshtml <br />
Areas/Identity/Pages/Account/Login.cshtml.cs <br />
Areas/Identity/Pages/Account/Logout.cshtml <br />
Areas/Identity/Pages/Account/Logout.cshtml.cs <br />
Areas/Identity/Pages/Account/Register.cshtml <br />
Areas/Identity/Pages/Account/Register.cshtml.cs <br />
Areas/Identity/Pages/Account/_StatusMessage.cshtml <br />
Areas/Identity/Pages/Account/_ViewImports.cshtml <br />
Controllers/ <br />
Controllers/BlogController.cs <br />
Controllers/BookingssystemController.cs <br />
Controllers/HomeController.cs <br />
Data/ <br />
Data/ApplicationDbContext.cs <br />
Data/HairdresserContext.cs <br />
Data/Migrations/ <br />
Data/Migrations/ 00000000000000_CreateIdentitySchema.Designer.cs <br />
Data/Migrations/00000000000000_CreateIdentitySchema.cs <br />
Data/Migrations/ApplicationDbContextModelSnapshot.cs <br />
Migrations/ <br />
Migrations/20200318011833_InitialCreate.Designer.cs <br />
Migrations/20200318011833_InitialCreate.cs <br />
Migrations/HairdresserContextModelSnapshot.cs <br />
Models/ <br />
Models/Blog.cs <br />
Models/Bookingssystem.cs <br />
Models/ErrorViewModel.cs <br />
Properties/ <br />
Properties/launchSettings.json <br />
Views/ <br />
Views/_ViewImports.cshtml <br />
Views/_ViewStart.cshtml <br />
Views/Blog/ <br />
Views/Blog/Create.cshtml <br />
Views/Blog/Delete.cshtml <br />
Views/Blog/Edit.cshtml <br />
Views/Blog/Index.cshtml <br />
Views/Blog/Bookingssystem/ <br />
Views/Blog/Bookingssystem/Create.cshtml <br />
Views/Blog/Bookingssystem/Index.cshtml <br />
Views/Blog/Home/ <br />
Views/Blog/Home/About.cshtml <br />
Views/Blog/Home/Contact.cshtml <br />
Views/Blog/Home/Course.cshtml <br />
Views/Blog/Home/Index.cshtml <br />
Views/Blog/Home/Prices.cshtml <br />
Views/Shared/ <br />
Views/Shared/Error.cshtml <br />
Views/Shared/_Layout.cshtml <br />
Views/Shared/_LoginPartial.cshtml <br />
Views/Shared/_ValidationScriptsPartial.cshtml <br />
wwwroot/ <br />
wwwroot/css/ <br />
wwwroot/css/main.css <br />
wwwroot/css/main.min.css <br />
wwwroot/sass/ <br />
wwwroot/sass/abstracts/ <br />
wwwroot/sass/abstracts/variables.scss <br />
wwwroot/sass/abstracts/all.scss <br />
wwwroot/sass/components/ <br />
wwwroot/sass/components/cards.scss <br />
wwwroot/sass/components/forms.scss <br />
wwwroot/sass/components/headings.scss <br />
wwwroot/sass/components/images.scss <br />
wwwroot/sass/components/lines.scss <br />
wwwroot/sass/components/links.scss <br />
wwwroot/sass/components/tables.scss <br />
wwwroot/sass/components/all.scss <br />
wwwroot/sass/core/ <br />
wwwroot/sass/core/reset.scss <br />
wwwroot/sass/core/all.scss <br />
wwwroot/sass/layout/footer.scss <br />
wwwroot/sass/layout/header.scss <br />
wwwroot/sass/layout/navigation.scss <br />
wwwroot/sass/layout/other.scss <br />
wwwroot/sass/layout/all.scss <br />
wwwroot/sass/pages/ <br />
wwwroot/sass/pages/about.scss <br />
wwwroot/sass/pages/contact.scss <br />
wwwroot/sass/pages/courses.scss <br />
wwwroot/sass/pages/all.scss <br />
wwwroot/sass/main.scss <br />
wwwroot/img/ <br />
wwwroot/img/Icon2.jpg <br />
wwwroot/img/icon1.png <br />
wwwroot/img/logo.jpg <br />
wwwroot/js <br />
wwwroot/js/main.js <br />
.gitignore <br />
Program.cs <br />
Projekt.csproj <br />
Projekt.csproj.user <br />
Projekt.sln <br />
ScaffoldingReadMe.txt <br />
Startup.cs <br />
appsettings.Development.json <br />
appsettings.json <br />
aspnet.PNG <br />

## 1.3 Installation <br>

Du kan ladda ner alla dessa filer och installera källkodsfiler i din lokala server eller egen webbplats. <br />

## 1.4 Programmeringsspråk som används i projektet: <br />

C#, HTML, CSS, Sass, Typescript och Javascript. <br />

## 1.5 Ramverk: <br />

ASPNET.CORE

## 1.6 Skärmdump av Intränatapplikation <br />

![alt text](https://github.com/fadihanna123/MinFrisor_ASPNET/blob/main/aspnet.PNG "Screenshot av hemsidan")
