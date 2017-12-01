# UNIT TESTING DEMO #
Very simple c#/.NET/xUnit demo of unit testing  

I've used this as a course material for unit testing training. The repo has different branches that each introduce a new issue and a solution for it. 

Feel free to use this if you ever find a need for it. For anything. If you need to ask something or have a better sample-case in mind, let me know.  

The sample case is pretty absurd so don't mind about that too much. 
  
The branches are as following:  

**master**  
Basic scenario with few methods and tests for them. Tests are done
with xUnit theories and parametrized for different cases.  

All tests pass. 

**NOTE**: This README.md file only exists in master-branch
  

**step-1**  
Introduces new test that fails. The code that corrects the failing test is commented out in the *Mathematics.cs*-file.  

**step-2**  
Introduces an ASP.NET Web API and the Mathematics-class is using this new API. Shows how external dependencies cause problems in unit testing. 
  
If you start the API you can see how the tests will pass.  
  
**NOTE**: Make sure the port number is correct in *Mathematics.cs*  

**step-3**  
Introduces *IMathService* that helps in mocking the API dependency away. I'm using Moq-library for mocking in tests. This service can then be dependency injected runtime. 

