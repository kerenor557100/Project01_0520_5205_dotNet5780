using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
	class GuestRequest 
	{
		public int GuestRequestKey { get; set; } //לבדוק
		public string PrivateName { get; set; }
		public string FamilyName { get; set; }
		public string MailAddress { get; set; }
		public String Status { get; set; } //לבדוק
		public DateTime RegistrationDate { get; set; }
		public DateTime EntryDate { get; set; }
		public DateTime ReleaseDate { get; set; }
		public String Area { get; set; } //לבדוק+enum
		public string SubArea { get; set; }
		public Type Type { get; set; }
		public int Adults { get; set; }
		public int Children { get; set; }
		public int Room { get; set; }
		public bool Pool; //enum //לבדוק
		public bool Jacuzzi; //enum //לבדוק
		public bool Garden; //enum //לבדוק
		public bool ChildrensAttractions;
		public ToString{}  //לבדוק
						   // להוסיף דברים





}
