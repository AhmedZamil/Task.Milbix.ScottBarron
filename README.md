# TASK for Milbix (ScottBarron) - Technical Challenge

 ## Delevery /Task Complete : 
(.NET SDK 6.0.4 Needs to be present) 
 
    ##  1. Download zip.
    ##  2. Set As Startup Project ( MVC App) you can run and browse https://localhost:7163/ 
    ##  3. Set As Startup Project ( Console ) you can run
    ### 4. Test Explorer : You can run unit test
  

 * Note : you will find the details below if you want to run development enviourment [Visual Studio 2022] 
 * Note : you will find the Navigation to application and few other comments about how it do.

## Developer Task & Requerments :

Task Description

In accounting, each year can be divided into a number of "periods" - for this exercise, each period can be considered to be one calendar month.
You will need to come up with a solution that generates a potentially infinite list of periods from a given start date.
Along with this output, you will also need to print out / display the period number (from 1 to 12), 12 being the period that comes at the end of the financial year which, for this exercise, will be June 30th. (i.e. July is period 1 and represents the start of the financial year).

Finally, you'll also be required to group all of the generated periods by financial year and list the amount of days in that financial year.
For example, if the start date entered into the program is "2020-07-02", the first returned result should have a start date of "2020-07-01", an end date of "2020-07-31" and a period number of 1.

Sample output:

Financial Year 2020-2021:
Days: 365
Periods:

Start End Period Number
2020-07-01 2020-07-31 1
2020-08-01 2020-08-31 2
2020-09-01 2020-09-30 3
2020-10-01 2020-10-31 4
2020-11-01 2020-11-30 5
2020-12-01 2020-12-31 6
2021-01-01 2021-01-31 7
2021-02-01 2021-02-28 8
2021-03-01 2021-03-31 9
2021-04-01 2021-04-30 10
2021-05-01 2021-05-31 11
2021-06-01 2021-06-30 12

Financial Year 2021-2022:
Days: 365
Periods:

Start End Period Number
2021-07-01 2021-07-31 1
2021-08-01 2021-08-31 2
etc etc ...



Architecture:
- Please code this as a c# solution. 
- Ensure that the functionality to generate the accounting calendar is portable and usable with ioc/dependency injection. 
- Use interfaces and/or abstract classes. 
- Ensue that your solution includes a demo project to demonstrate the accounting calendar, and a test project for unit tests. 
- utilize an OO inheritance approach if suitable.

Bonus points:
Bonus points for if you can allow the user to modify the start month of the financial year (in the example above the start month is 7 i.e. July). But in New Zealand the first month of the financial year is April. Please comment your code




## Delevery / TASK Submission : Details

#  Project Submission :
  I have include several solution ( just to express myself & create a bit impression)
  
     1. Console App : Straight Cut solution & calling to find out and achieve out put according to your Sample output ( using The Class library seperated)
     2. ASP.NET Core (6.0) MVC web app to ensure points you mentioned instructions.
     3. Class library : to maintain a DAL to achieve and demonastrate using DI container - Abstruction - Interfacing etc.
     4. Unit test project ( xunit) to demonastrate Arrange- Act-Assert ( explain Fact).For simple

# Requirements Covered :
   1. Need to come up with a solution that generates list of periods from a given start date.
   2. Need to print out / display the period number (from 1 to 12).
   3. 12 being the period that comes at the end of the financial year which, for this exercise, will be June 30th. (i.e. July is period 1 and represents the start of the financial year).
   4.Finally, required to group all of the generated periods by financial year and list the amount of days in that financial year.
   5. According to sample output.
   6.Please code this as a c# solution.
     i.Console App : Straight Cut solution & calling to find out and achieve out put according to your Sample output ( using The Class library seperated)
     ii.ASP.NET Core (6.0) MVC web app to ensure points you mentioned instructions.
     
   7. Ensure that the functionality to generate the accounting calendar is portable and usable with ioc/dependency injection.
   8. Use interfaces and/or abstract classes.
   9. Ensue that your solution includes a demo project to demonstrate the accounting calendar, and a test project for unit tests.
    i.ASP.NET Core (6.0) MVC web app to ensure points you mentioned instructions.
    ii.Console App : Straight Cut solution & calling to find out and achieve out put according to your Sample output ( using The Class library seperated).
    iii.Unit test project ( xunit) to demonastrate Arrange- Act-Assert ( explain Fact).For simple

 # Bonus points Covered : 
 1. Allow the user to modify the start month of the financial year (in the example above the start month is 7 i.e. July). But in New Zealand the first month of the financial year is April.
  i.I have added a simple form.User can select the starting month of the financial year.
  ii. According to this listing will act.
  iii. And also starting and End date input.(Initially they are set to default as you mentioned)
 2. Please comment your code and utilize an OO inheritance approach if suitable.
  i. I have tried my best to Comment ( with asserative language).
  ii. Also Trying to include some more in this file
   
# NOTE : As I understood. You set 5 hours of time.( I asked myself & gussed ) It must be the Time Limit you want me to compe up with the solution ( may be to see efficency).So I tried not to utilize enough time to have a clear view about me.That includes several lack of in solution that I might want to work but resist myself.To be honest I took little bit more just to write the deliverables in understanding way.(My apology)
Apolized for ignoring 
   i.Unit Test project is not very much healthy ( it should be).
   ii.In few place some over done or over calculating might be.Could have more "DRY" and Improvement.
   iii.ASP.NET Core MVC project is not that much good looking.
   iv. Could have more refactor of View Models or few Code ( but ignored to being focused on time).
   v.I had a plan to Deploy the MVC project in azure to better deliverables, a Video of explaining my code & Timing ( you might want to feel trusted, Sometimes it seems that I'm myself is working or not).
   


# Technologies
 - ASP.NET Core ( 6.0)
 - C#
 - xunit 


# Good to share 
  - I have tried to have the best possible impression , thats why took time to polish & beutify
  - Tried to maintain n-tier Architecture along with Repository pattern.
  - Tried to maintain S O L I D and the points you mentioned
  - It could be more seperated and portable (Bussiness Layer) Uses Interface -Mixed N-tier

# Prerequisites ( If some body want's to take the code in visual studio)

## Only [.NET Core 6.0.4 SDK] (.NET SDK 6.0.4 : https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-6.0.4-windows-x64-installer) has to be present to Run
## Set As Startup Project ( MVC App) you can run and browse https://localhost:7163/ 
## Set As Startup Project ( Console ) you can run


How It Works ( More Comments) Few Points ( might seems a bit overdone , my apology).

- I have tried to implementation  an interface IAccountingCalendarGenerator with a single method Generate that takes a start date ,an end date, optional starting Month of the financial year ( if not given it will take July as) and returns the periods and financial years in the range. 

- The Period class represents a single accounting period with a period number, start date, and end date. The FinancialYear class is a subclass of Period that represents a financial year with an additional property for the number of days in the year.

To make the functionality to generate the accounting calendar portable and usable with IOC/dependency injection, created  interface and class that implements that interface to generating the periods and grouping them by financial year.I have tried to use DI standard use like In Constructor Injection.While AddScoped in Service collection.


