CREATE TABLE Movies

(

       ID int primary key identity (1,1),

       Title varchar(50),

       Director varchar(200),

       Year int,

	   LeadingMaleRole varchar(200),

	   LeadingMaleRoleAge int,

	   LeadingMaleRoleAgeStudio varchar(100),

	   LeadingMaleRoleAgeStudioAddress varchar(500),

	   LeadingFemaleRole varchar(200),

	   LeadingFemaleRoleAge int,

	   LeadingFemaleRoleStudio varchar(100),

	   LeadingFemaleRoleStudioAddress varchar(500)



)