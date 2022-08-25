<!-- --------------- Contact Buttons --------------- -->
<div align="right">
	<a href="mailto:DaniellaJPotts@gmail.com" alt="Gmail" title="Send me an Email!">
		<img src="https://img.shields.io/badge/-Gmail-EA4335?logo=gmail&logoColor=white&style=for-the-badge">
	</a>
	<a href="https://www.linkedin.com/in/daniellajpotts/" alt="LinkedIn" title="Connect to me on LinkedIn!">
		<img src="https://img.shields.io/badge/-LinkedIn-0A66C2?logo=linkedin&logoColor=white&style=for-the-badge"
	</a>
	<a href="https://twitter.com/DaniellaJPotts" alt="Twitter" title="Follow me on Twitter!">
		<img src="https://img.shields.io/badge/-Twitter-1DA1F2?logo=twitter&logoColor=white&style=for-the-badge">
	</a>
</div>


<!-- --------------- Title & Languages --------------- -->
<div>
	<h1>🌍 ASP.NET MVC Login Proof of Concept (POC)</h1>
	<img src="https://img.shields.io/badge/-ASP%2ENET_6%2E0_MVC-30363d?logo=.net&logoColor=white&style=for-the-badge">
	&emsp;
	<img src="https://img.shields.io/badge/-HTML-30363d?logo=html5&logoColor=white&style=for-the-badge">
	<img src="https://img.shields.io/badge/-CSS-30363d?logo=css3&logoColor=white&style=for-the-badge">
	<img src="https://img.shields.io/badge/-JavaScript-30363d?logo=javascript&logoColor=white&style=for-the-badge">
	<img src="https://img.shields.io/badge/-C%23-30363d?logo=csharp&logoColor=white&style=for-the-badge">
</div>


<!-- --------------- Description --------------- -->
<div>
	<h2>Description</h2>
	<p>
		This project is a simple ASP.NET 6.0 MVC web application, demonstrating a login system Proof of Concept.
		Here users can complete the login form, entering one of two account details.
		Once logged in, the user will be taken to the Authentication page, where a mock text message will appear on the screen.
		Uppon successfully completing the Authentication form using the 6 digit code provided,
		users will be greeted with a Welcome page specific to the account entered.
	</p>
	<table>
		<caption>The account details in this application are as followed:</cation>
		<tr>
			<th>Email Address</th>
			<th>Password</th>
			<th>Forename</th>
			<th>Surname</th>
		</tr>
		<tr>
			<td>admin.account@example.com</td>
			<td>AdminPassword123</td>
			<td>Admin</td>
			<td>Account</td>
		</tr>
		<tr>
			<td>DaniellaJPotts@gmail.com</td>
			<td>Hello, World!</td>
			<td>Daniella</td>
			<td>Potts</td>
		</tr>
	</table>	
	<blockquote>
		Note - Email addresses are NOT case-sensitive.<br>
		Note - Passwords are NOT saved in the Dictionary.
	</blockquote>
	<details>
		<summary>Login Page</summary>
		<p>
			Below is the Login (and index) page for this project.
			This page features a simple navigation bar with a home button, login form, and contact links in the footer. 
			When correctly completiting the form and clicking the "Login to LoginPOC" button,
			users will be taken to the Authentication page where they can complete logging in.
		</p>
		<div align="center"><img width=75% src="Images/LoginPOC - Login.png"></div>
		<div align="center"><img width=75% src="Images/LoginPOC - Logging in.png"></div>
		<p>
			When entering invalid data, users will be prompted to enter the correct pattern of data to the form.
		</p>
		<div align="center"><img width=75% src="Images/LoginPOC - Login Validation .png"></div>
		<p>
			If an error occurs, such as if the entered information doesnt match an account, users will be shown an appropriate error message.
		</p>		
		<div align="center"><img width=75% src="Images/LoginPOC - Login Error.png"></div>
	</details>
	<details>
		<summary>Authentication Page</summary>
		<p>
			Below is the Authentication page, seen after successfully logging in to an account.
			The first thing users will see when entering the page is a mock text message displaying their authentication code.
			When closing this message the authentication code can be entered into the form, and submitted using the "Continue" button
			Upon successful completion, the user will be taken to the Welcome Page.
			The mock text message can be seen again by clicking the "View Message" button in the bottom right corner of the page.
		</p>
		<div align="center"><img width=75% src="Images/LoginPOC - Authentication Message.png "></div>
		<div align="center"><img width=75% src="Images/LoginPOC - Authentication.png "></div>
	</details>
	<details>
		<summary>Welcome Page</summary>
		<p>
			Below is the Welcome page, seen after successfully logging in and completing the 2FA.
			This page features the same navigation bar and footer as the previous pages, in addition to a welcoming message unique to the account.
			From here the only other option is to return to the Login page.
		</p>
		<div align="center"><img width=75% src="Images/LoginPOC - Welcome.png"></div>
	</details>
</div>


<!-- --------------- Assets --------------- -->
<div>
	<h2>Assets</h2>
	<p>
		In this project I used Bootstrap 5, to easily and quicky allow me to create 'vanilla' styled pages for the project.
		In addition to this I made use of Vjacheslav Trushkin's Material Line Icons from his site, Iconify.
		These icons were used for the contact buttons seen in the footer. 
	</p>		
	<a href="https://getbootstrap.com/" alt="Bootstrap 5" title="Bootstrap 5">
		<img src="https://img.shields.io/badge/-Bootstrap_5-7952B3?logo=bootstrap&logoColor=white&style=for-the-badge">
	</a>
	<a href="https://icon-sets.iconify.design/line-md/" alt="Iconify, Material Line Icons" title="Iconify, Material Line Icons">
		<img src="https://img.shields.io/badge/-Iconify-1769AA?logo=iconify&logoColor=white&style=for-the-badge">
	</a>	
	<blockquote>Both assets are under the MIT licence.</blockquote>
</div>
