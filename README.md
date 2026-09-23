 # Intro to API's .NET, & status codes, Http Request Methods

 What does API stand for?

  ## Application Program Interface

  ** API allows different applications to communicate with each other **

  ** Front end -> API -> Data -> API -> Front end.

   ## .NET is Microsofts Developement Platform

   ** Dotnet Lets us create application from Console Project to web API to frontend website **

    ## What is an Endpoint

    An end endpoint is a specified location where we send our requests to (ex: localhost5000/user/api/login)

     ## What is a controller

Controllers Hold our Endpoints and allows applications to send requests to them

** Request -> Controller -> C# Logic -> request / response is sent back

 ## CRUD - Create, Read, Update & Delete


 ### Read Method [HttpGet]

 Retrieves Data from our API / Database

 ### Create Method [HttpPost]

 Used to create new Data (ex creating a new account)

 ### Update Method [HttpPut]

 Used to *Update existing data*

 ### Delete Method [HttpDelete]

 Used to *delete existing Data*

 //-------------------------------------------------------//


 # Status Codes

 ##200 Status Code 
 
 means your request is good - success

##201 status code

this means our creation was successful
(used for CreateAtaction)

##204 status code
simply states he request was successful with nothing to return
(NoContent)

 ##400 Status code 
 
 means a bad request, something was wrong with request

 ##404


 //------------------------------------------------------//


 ## Day Three Services, Interfaces and Dependancy Injection

 # Controller is our waiter -- Takes orders (Request Methods)

 # Interface is our menu -- Tells us what our kitchen has

 # Services is our kitchen -- Makes the food (implements our logic)

 # Dependancy Injection is our Manager -- Makes sure Everything runs smoothly (Connects everything)


 ### Services

 This layer of our application is where our logic resides (we access our database from this layer only)


 ### Interface

 this is a contract or a list of promises that our services must implement (there is no logic here)


 ### Dependancy Injection

 we inject our services into the controller using our constructor
 we must add our services and interface 