Project Name:
DemoblazeBDD 

Overview: This project utilizes Visual Studio with .NET framework for automated testing of web applications using Selenium WebDriver, NUnit, and SpecFlow. It provides a robust framework for writing and executing behavior-driven tests, ensuring efficient testing processes using Page object Model.

Installation:
Clone the repository to your local machine:
git clone https://github.com/ddhanashrichavan/DemoblazeBDD.git

Prerequisites:
Before running this project, ensure you have the following installed:

Visual Studio: Integrated Development Environment (IDE) for .NET development.
.NET Framework: Framework for building Windows applications.
Selenium WebDriver: Automation tool for web browser testing.
NUnit: Unit-testing framework for .NET applications.
SpecFlow: Tool for behavior-driven development (BDD) in .NET.

Usage:
Open the project "DemoblazeBDD.sln" solution file in Visual Studio 2022 (you can use other visual studio version as well)
Ensure you have the necessary NuGet packages installed. If not, restore them.
right click on solution -> Restore NuGet packages 



Directory Structure:
PageObjects/: Contains page object classes for interacting with web pages.
Drivers/: Includes WebDriver configuration and setup.
Features/: Holds SpecFlow feature files defining test scenarios.
StepDefinitions/: Contains SpecFlow step definition files corresponding to feature files.
Pages/: webelements and reusable function
Hooks/: initializing WebDriver instances, opening and closing browsers
Support/: class contains methods to create instances of different page objects.
Each method returns an instance of a specific page object.

View the project files in Solution explorer -> top menu -> view -> Solution Explorer

Run your test:
Open your Visual Studio solution.
Step 1: From the top menu, go to Build > Clean Solution.
Step 2: Go to Build > build Solution.
Step 3: Go to Test > Test Explorer.
Once the solution is built, open Test Explorer.
Step 4: Run the project by clicking on green button on top in Test Explorer or right click on specific test case if wants to run single scenario.






