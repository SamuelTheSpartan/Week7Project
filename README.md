<img src="https://magento.softwaretestingboard.com/pub/static/version1678540400/frontend/Magento/luma/en_US/images/logo.svg" alt="Luma Wesbite Logo" width="600" >

# Luma Web Testing Project using Selenium and Specflow

## This is a web testing project on [the Luma software testing website](https://magento.softwaretestingboard.com/) that utilises Selenium, Specflow, Accessibility Testing and Exploratory Testing.

🥅 [Testing Aims](#🥅-testing-aims) | 🎉️ [Epics](#🎉️-epics) | 🏷 [Class Diagram](#🏷-class-diagram) | 🚢 [Exploratory Testing](#🚢-exploratory-testing) |
🗺 [Accessibility Testing](#🗺-accessibility-testing) | ❌ [Defect Reports](#❌-defects-reports) |
💭 [Definitions of Done and Ready](#💭-definitions-of-done-and-ready) | 📝 [Project Board](#📝-project-board) | 🤺 [Contributors](#🤺-contributors)

---

### 🥅 Testing Aims

The testing aims of this project are...

* [ ] To have an up to date project board
* [ ] To have high quality user stories and test cases
* [ ] To have very clear Gherkin scenarios derived from user stories represent the user journeys
* [ ] To have a fully functional test framework using POM pattern
* [ ] Well documented defect reports
* [ ] Exploratory Test Charters
* [ ] GitHub Action Workflows

---

### 🎉️ Epics

<details>
<summary>Epic 1.0 - Signin</summary>
1.1 <br>AS a registered user <br>I WANT TO login to the system <br>SO THAT only I can access my account <br> 1.2 <br>AS a registered user <br>I WANT TO request a new password <br>SO THAT I can access my account <br>1.3 <br>AS a registered user <br>I WANT TO be able to change my password <br>SO THAT my account is secure
</details>

<details>
<summary>Epic 2.0 - Create Account</summary>
2.1 <br>AS a new user <br>I WANT TO signup on Luma with valid credentials <br>SO THAT so I can have an account <br>2.2 <br>AS a new user <br>I WANT TO be prompted if my credentials aren't valid <br>SO THAT so I amend my credentials <br>2.3 <br>AS a new user <br>I WANT TO be prompted if my password isn't strong enough <br>SO THAT so I can amend it <br>2.4 <br>AS a new user <br>I WANT TO be prompted if I try to create an account with an already registered email<br>SO THAT so I know to signin, not signup.
</details>

<details>
<summary>Epic 3.0 - Navigation</summary>
2.1 <br>AS A Luma user <br>I WANT TO be taken to the correct page when I click a link <br>SO THAT I can easily navigate <br>2.2 <br>AS A Luma user <br>I WANT TO be relevant dropdowns to be displayed when I hover over a navigation header <br>SO THAT I can easily navigate
</details>

<details>
<summary>Epic 4.0 - Signin</summary>
4.1 <br> AS A registered user <br>I WANT TO be able to add an item(s) to the cart <br>SO THAT I can buy items 4.2 <br> AS A registered user <br>I WANT TO be able to add a large number of items to my basket
<br>SO THAT I can buy items in bulk <br>4.3 <br>AS A registered user <br>I want the cart icon to show me my items <br>SO THAT I can see if I have added the correct items to the basket 
</details>

<details>
<summary>Epic 5.0 - Searchbar</summary>
5.1 <br> AS A Luma user <br>I WANT TO relevant products and results to be returned when I search a term <br>SO THAT I can easily find products
</details>
<br>

### 🏷 Class Diagram

<details>
<summary>A Class Diagram for Automated Test Functions</summary>
<img src="./readme_assets/automated_test_functions.png" alt="A Class Diagram for Automated Test Functions" width="1000">
</details>

<details>
<summary>A Class Diagram for the Page Object Model</summary>
<img src="./readme_assets/pom.png" alt="A Class Diagram for the Page Object Model" width="1000">
</details>
<br>

### 🚢 Exploratory Testing

We carried Exploratory Testing on all our Epics to supplement our automated testing. The links to our Test Charters and Test Cases are attached below.

* [ ] [Epic 1.0 - Signin](https://drive.google.com/drive/folders/1bQZ-y8z6K7P_c7QnnWDM34YowUi9qQ-x?usp=share_link)
* [ ] [Epic 2.0 - Create Account](https://drive.google.com/drive/folders/185aEqa-vtyUK_CrELnw9sOGPT_M397h8?usp=share_link)
* [ ] [Epic 3.0 - Navigation](https://drive.google.com/drive/folders/1NvtlIi4lHZ3bysir2qNoTz4hsuqQjPEa?usp=share_link)
* [ ] [Epic 4.0 - Buying Items](https://drive.google.com/drive/folders/1R_b7zjIYdjDOvKBHcMI3hF5gF4EoH5Hv?usp=share_link)
* [ ] [Epic 5.0 - Searchbar](https://drive.google.com/drive/folders/16jjiAilnOMSfckMFn-YbefsdBG2kaMKI?usp=share_link)

### 🗺 Accessibility Testing

We carried some Accessibility Testing. The key takeaway from this testing was that certain elements of the website weren't intuitively in sequence and other elements weren't accessible at all. Our full report [can be found here](https://drive.google.com/drive/folders/1oBh03-AduD9liG7J4TVAnJMtVbZfJkpR?usp=share_link)

### ❌ Defects Reports

Our [open defect reports can be found here](https://drive.google.com/drive/folders/1mGbFK7zAuXJb4K-djAReCqDfZ2ipEwOt?usp=sharing). They relate to accessibility defects which violate the lowest level of Web Content Accessibility Guidelines and to defects around basic functionality around purchasing certain products.

---

### 📝 Project Board

Our up-to-date GitHub project board [can be found here](https://github.com/users/SamuelTheSpartan/projects/1/views/1)

### 💭 Definitions of Done and Ready

Our definitions of Done and Ready [can be found here](./Defintions%20of%20Done%20and%20Ready/Definitions%20of%20Done%20and%20Ready.md)

### 🤺 Contributors

Samuel Burton, Lucas Brennan, Man Him Yeung, Glen Smith, Gharzay Wali, Ali Cengiz, Suheyb Adam, Cormac Porter, Kevin Conceicao

---

[The Project Website](https://magento.softwaretestingboard.com/)

[Project Board](https://github.com/users/SamuelTheSpartan/projects/1/views/1)

### Other deliverables

* [ ] A README.md that includes all your documentation of what you have tested and how to run your test framework. Should also include how to use and extend your framework
* [ ] Using GitHub collaboratively
* [ ] Present your work at 9.30am on Wednesday 12th April (everyone in the group must partake – treat like a final presentation)
