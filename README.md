# Locate Missile Fall Project
this project simulates emergency telephone service center, <br/>
civilian call the center when they hear "boom" as a result of missile fall, <br/>
every 10 minutes are one period of time, all the reports in these 10 minutes are refer to the same fall (there is only 1 fall in 10 minutes) <br/>
the field "num of explosions" in add report must be 1 for the project to work with no deadlock <br/>

the black pin is where the real fall location is <br/>
the red pin is the reports <br/>
the blue pin is where the k-means algorithm calculate the estimated fall location  <br/>

![photo_2019-09-17_18-23-58](https://user-images.githubusercontent.com/35970325/68087628-68cb9a00-fe60-11e9-9710-6c706f35b1ca.jpg)

![photo_2019-09-17_22-43-00](https://user-images.githubusercontent.com/35970325/68087840-e80d9d80-fe61-11e9-962c-a22f88578314.jpg)

## steps before running the project:
1. in the BL/BLImp put your bing map key in the currect place ("YOUR_BING_MAP_KEY") in Geocode and ReverseGeocode functions
2. in the PL/NewFallUC in the Copy function change the "backupDir" to your PL/images url
