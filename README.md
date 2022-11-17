# Presale_Sniper

This program is intended for educational purposes only.  I am not responsible in any way for its use or misuse.
I have not used this in any meaningful way nor do I intend to and you shouldn't either.

It is a fully functional sniper program for hive blockchain custom_json posts.  It can use active or posting keys.
This program represents about 10 hours worth of programming time.  It is not complex by any means.

I have been campaigning for awhile for change and presale botting has gotten worse and worse.
I could keep quiet and make thousands of dollars, but that isn't my style.
I am going to share how to exploit the current presale system.
The sole purpose of this is to force splinterlands to fix their system.
I didn't want to go this far, but with the Lux sale (and others before it) it is clear others are already taking advantage.  

This program has the potential to post lots and lots of transactions. 
Okay enough talk 
Lets go over how it works

First the config.
There are several .ini files each has a purpose and it should be pretty easy to understand.

Main_Settings.ini - Contains the main settings for your presale buy including 
the purchase code the number of attempts per account and the datetime to try (based on your pc) and the type of key required

Datetime= (This is the datetime on your machine that the code will execute the purchases)
attempts= (This is the number of attempts it will make with each account you can do between 1 and 5 attempts per account)
active= (True or False if True then use active keys in settings if false then use posting keys)
custom_id= (this is the id on the blockchain for presales it is usually sm_shop_purchase or sm_purchase but it depends)
custom_json (this is the json that gets posted see below)

you can copy and paste this from a blockchain viewer once its exposed or set the date manually ahead to get the data (don't forget to set it back)
if there are variables that need to be added you can replace the values with [var_1] or whatever number up to 10
for the random n number you can use [randomN]

so for the lux sale if you wanted to use variable vouchers per account you could do this
[BuyDemo]
Datetime=11/15/2022 3:00:00 PM
attempts=5
active=true
custom_id=sm_shop_purchase
custom_json={"id":"lux_vega_promo_card","qty":1,"vouchers_used":[var_1],"app":"splinterlands/0.7.139","n":"[randomN]"}

Then you set it up in the settings file.
you need 1 settings file per account you want to use
these should be numbered as such settings_1.ini to settings_2147483647.ini (yeah any number of accounts up to int max)
make sure you number them sequentially starting with 1

[BuyDemo]
Hive_Account=(hive account name all lowercase)
Hive_Key=(active or posting key based on main settings)
var_1=(custom variables to modify the json as needed can be left any value if not used)
var_2=2
var_3=3
var_4=4
var_5=5
var_6=6
var_7=7
var_8=8
var_9=9
var_10=10
delay=(delay in ms between purchase attempts you will want this at least 3000 perhaps as high as 5000)

Once you have all the ini files setup you simply launch BuyDemo.exe and pass a parameter of the number of settings to open.

Then double click and away you go.  




