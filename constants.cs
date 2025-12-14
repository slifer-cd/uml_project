namespace Constants
{
    class FileStartups
    {
        public static readonly string studentStartup = "[" + "{\"userID\":\"S01\",\"userName\":\"Ali\",\"registeredCourses\":[\"CPE100\", \"SE400\"]}," +
                                                            "{\"userID\":\"S02\",\"userName\":\"Omar\",\"registeredCourses\":[\"CPE100\", \"NES200\"]}," +
                                                            "{\"userID\":\"S03\",\"userName\":\"Reem\",\"registeredCourses\":[\"NES200\", \"CIS300\", \"SE400\"]}," +
                                                            "{\"userID\":\"S04\",\"userName\":\"Maher\",\"registeredCourses\":[\"CPE100\", \"SE400\"]}" + "]";
        public static readonly string facultyStartup = "[" + "{\"userID\":\"F01\",\"userName\":\"Sami\",\"taughtCourses\":[\"CPE100\", \"CIS300\"]}," +
                                                            "{\"userID\":\"F02\",\"userName\":\"Eman\",\"taughtCourses\":[\"NES200\", \"SE400\"]}" + "]";
        public static readonly string cardStartup = "[" + "{\"number\": 10, \"balance\": 80, \"utype\": \"faculty member\",\"blocked\": false,\"uesrID\":\"F02\"},"
                                                       + "{\"number\": 20, \"balance\": 110, \"utype\": \"student\",\"blocked\": false,\"uesrID\":\"S02\"},"
                                                       + "{\"number\": 30, \"balance\": 95, \"utype\": \"student\",\"blocked\": true,\"uesrID\":\"S03\"},"
                                                       + "{\"number\": 40, \"balance\": 160, \"utype\": \"student\",\"blocked\": false,\"uesrID\":\"S04\"}" + "]";
    }
}
