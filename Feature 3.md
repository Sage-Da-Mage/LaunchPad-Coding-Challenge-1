Feature 3
==========

**Please describe two ways you could provide authorization to your API to limit who can access it:**
------------------------------------------------------------------------------------------------------

The way I see it there are two major ways I know of to provide authorization to my API.  

The first way is to gatekeep access to your API through a password/user system that will reliably deny acess to those who haven't signed up with you.
That's a good first step to protecting your systems from outsiders. This would primarily be done through security platforms such as Auth0 or other such providers of security.
Another security/authorization method to keep in mind while on the topic of the username/password security topic is role allotment. Having important code be protected by checks
that only allow users with certain roles have acess to it is a great way to keep your API safer. 

The second way I am aware of is more mundane than user/password systems but is also quite important. Keeping your code as secure as possible 
