# _Jeopicodus API_

#### _Get and Post all the Epicodus trivia you could ever need! {11/6/2019}_

#### By _**Christine Frank, Mike McShane, Chris Burge, and Devin Cooley**_

## Description

_The purpose of this application is to allow a client to query and add Jeopardy questions based on our epicodus curriculum._  

## Specifications
* #### Endpoints
| Method                    |Path       | Input |   Output|
|:---------------------------|:-------------|:------|:----|
|Get|"/api​/FillInTheBlank"| ""|`List of Fill In The Blank Questions in JSON format`|
|Get|"/api​/FillInTheBlank/`{id}`"| `{id}`|`Fill In The Blank Question in JSON format`|
|Get|"/api/MultipleChoice |""|`List of Multiple Choice Questions in JSON format` |
|Get|"/api/MultipleChoice/`{id}`" |`{id}`|`Multiple Choice Question in JSON format` |
|Post|"/api/FillInTheBlank" |`FillInTheBlank Question ObJect`| `None`|
|Post|"/api/MultipleChoice" |`Multiple Choice Question Object`| `None`|



## Setup/Installation Requirements
_Call this API from your browser or another client. Post routes may only be called from a registered user on the Play Jeopicodus application._

## API Location  
* https://jeopicodusapi.azurewebsites.net
## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Send any questions or comments to:
Christine Frank at christine.braun13@gmail.com  
Chris Burge at topher.burge@gmail.com
Mike McShane at  mmchane10@gmail.com 
Devin Cooley at dcooley1350@gmail.com._

## Technologies Used

_This is a .NET Core application written primarily in C#. Databasing was accomplished with Mysql, assisted by Entity Framework. This application and the accompanying databases are hosted using Microsoftthe Azure Cloud. Query this application from your browser or other client._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Devin Cooley, Christine Frank, Chris Burge, Mike McShane_**