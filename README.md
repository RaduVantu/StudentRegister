<h2> Student and teacher register </h2>

<h3> Description </h3>

<p>This project proposes an applied solution in the form of a new Student Register software developed in the Visual C# programming environment and sporting a modern user interface and fast query responses. To reproduce a real-life situation more fatefully, a scenario is created where Science College, an imaginary education institution, has contracted me to produce the software with the following requirements:</p>

<ul>
	<li>Fully modifiable (add, modify, delete) database that will hold the following student information: student number, title, surname, middle name(s) (if any), name, course, course type (day, evening, distance), year, group (if more than one per course, type and year), date of birth, home address, study address, telephone number, personal email, education email and emergency contact</li>
	<li>Fully functional database management software capable of using multiple search filters</li>
	<li>The software must be easy to use and require minimal training, thus it must include a modern user interface designed to improve query input, query result visualization and provide easy access to additional functions, such as the QR code printing</li>
	<li>Because access to the college grounds is done by scanning unique barcodes present on the student ID cards, the software must also include a QR code printing feature to facilitate short term access (24 hours) in case of lost, stolen or forgotten student IDs.</li>
	<li>The program should include interface elements that can be used as links to the existing contacts register, timetable register and academic records programs already existent at Science College</li>
</ul>

<p>The full database script (including Stored Procedures and test data) can be found in \Additional Resources\DB Script\Database - Full Script.sql. Just open the file in Visual Studio and hit run. Once done, check App.config and replace the connection string if needed</p>

<h3> Technology used </h3>
<a href="https://visualstudio.microsoft.com/vs/older-downloads/">Microsoft Visual Studio 2019</a></br>
<a href="https://dev.mysql.com/downloads/mysql/">Microsoft MySQL Server</a>

<h3> Images </h3>
<br/>
<br/>
<p align="center"> 
	Home screen <br/>
	<a href="https://imgur.com/VXIycwH"><img src="https://i.imgur.com/VXIycwH.jpg" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Student search <br/>
	<a href="https://imgur.com/uQ5fdvh"><img src="https://i.imgur.com/uQ5fdvh.jpg" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Double-clicking a search result (or selecting and pressing Enter) opens the student's profile <br/>
	<a href="https://imgur.com/WHfEkkR"><img src="https://i.imgur.com/WHfEkkR.jpg" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Generated QR code <br/>
	<a href="https://imgur.com/SQsBxkN"><img src="https://i.imgur.com/SQsBxkN.png" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Edit student profile window <br/>
	<a href="https://imgur.com/TLXba7Y"><img src="https://i.imgur.com/TLXba7Y.jpg" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Add new student (red field tags are mandatory and become black when filled). Student ID is auto-generated <br/>
	<a href="https://imgur.com/HJIFr8H"><img src="https://i.imgur.com/HJIFr8H.jpg" title="source: imgur.com" /></a>
	<br/>
	<br/>
	Teacher profile <br/>
	<a href="https://imgur.com/VPywIiS"><img src="https://i.imgur.com/VPywIiS.jpg" title="source: imgur.com" /></a>	
</p>
