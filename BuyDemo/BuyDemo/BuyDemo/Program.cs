using HiveAPI.CS;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuyDemo
{
    internal class Program
    {
        #region Variables
        private static HttpClient oHTTP = new HttpClient();
        private static CHived oHived = new CHived(oHTTP, "https://anyx.io");
        private static string hive_user_1 = "";
        private static string hive_key_1 = "";
        private static string delay = "";
        private static string var_1 = "";
        private static string var_2 = "";
        private static string var_3 = "";
        private static string var_4 = "";
        private static string var_5 = "";
        private static string var_6 = "";
        private static string var_7 = "";
        private static string var_8 = "";
        private static string var_9 = "";
        private static string var_10 = "";
        private static string active = "";
        private static string demo = "";
        private static Random ran = new Random();
        private static int attempts = 0;

        private static object[] c_0;
        private static object[] c_1;// = { custom_json1 };
        private static object[] c_2;// = { custom_json2 };
        private static object[] c_3;// = { custom_json3 };
        private static object[] c_4;// = { custom_json4 };
        private static string[] key;// = { hive_activekey_1 };


        #endregion

        static async Task Main(string[] args)
        {
            string instance = "";
            try
            {
                instance = args[0];
            }
            catch (Exception)
            {
                Environment.Exit(-1);
            }
            string filepath = Environment.CurrentDirectory;
            var Main_Settings = new IniFile(filepath + "\\Main_Settings.ini");
            var Settings = new IniFile(filepath + "\\Settings_" + instance + ".ini");
            hive_user_1 = Settings.Read("Hive_Account");
            delay = Settings.Read("delay");
            var_1 = Settings.Read("var_1");
            var_2 = Settings.Read("var_2");
            var_3 = Settings.Read("var_3");
            var_4 = Settings.Read("var_4");
            var_5 = Settings.Read("var_5");
            var_6 = Settings.Read("var_6");
            var_7 = Settings.Read("var_7");
            var_8 = Settings.Read("var_8");
            var_9 = Settings.Read("var_9");
            var_10 = Settings.Read("var_10");
            hive_key_1 = Settings.Read("Hive_Key");
            try
            {
                active = Main_Settings.Read("active");
                DateTime target = DateTime.Parse(Main_Settings.Read("Datetime"));
                DateTime now = DateTime.Now;
                attempts = int.Parse(Main_Settings.Read("attempts").ToString());

                Console.SetWindowSize(150, 16);
                Console.SetBufferSize(150, 16);
                Console.Clear();
                demo = Main_Settings.Read("demo");
                string customjson = Main_Settings.Read("custom_json");

                customjson = customjson.Replace("[var_1]", var_1);
                customjson = customjson.Replace("[var_2]", var_2);
                customjson = customjson.Replace("[var_3]", var_3);
                customjson = customjson.Replace("[var_4]", var_4);
                customjson = customjson.Replace("[var_5]", var_5);
                customjson = customjson.Replace("[var_6]", var_6);
                customjson = customjson.Replace("[var_7]", var_7);
                customjson = customjson.Replace("[var_8]", var_8);
                customjson = customjson.Replace("[var_9]", var_9);
                customjson = customjson.Replace("[var_10]", var_10);

                string customjson_1 = customjson.Replace("[randomN]", randomN());
                string customjson_2 = customjson.Replace("[randomN]", randomN());
                string customjson_3 = customjson.Replace("[randomN]", randomN());
                string customjson_4 = customjson.Replace("[randomN]", randomN());
                string customjson_5 = customjson.Replace("[randomN]", randomN());
                string customid = Main_Settings.Read("custom_id");

                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Blue;

                if(demo != "false")
                {
                    Console.WriteLine("Presale Sniper Demo " + instance);
                }
                else
                {
                    Console.WriteLine("Presale Sniper " + instance);
                }

                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Hive Account : " + hive_user_1.ToLower());
                Console.WriteLine("Attempts     : " + attempts);
                Console.WriteLine("Json         : " + customjson);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;

                //Parse our custom_json first

                if (active.ToLower() == "true")
                {
                    COperations.custom_json custom_json = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_1,
                        required_auths = new string[] { hive_user_1.ToLower() },
                        required_posting_auths = new string[] { }
                    };
                    COperations.custom_json custom_json1 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_2,
                        required_auths = new string[] { hive_user_1.ToLower() },
                        required_posting_auths = new string[] { }
                    };
                    COperations.custom_json custom_json2 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_3,
                        required_auths = new string[] { hive_user_1.ToLower() },
                        required_posting_auths = new string[] { }
                    };
                    COperations.custom_json custom_json3 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_4,
                        required_auths = new string[] { hive_user_1.ToLower() },
                        required_posting_auths = new string[] { }
                    };
                    COperations.custom_json custom_json4 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_5,
                        required_auths = new string[] { hive_user_1.ToLower() },
                        required_posting_auths = new string[] { }
                    };

                    object[] c_0t = { custom_json };
                    object[] c_1t = { custom_json1 };
                    object[] c_2t = { custom_json2 };
                    object[] c_3t = { custom_json3 };
                    object[] c_4t = { custom_json4 };
                    string[] keyt = { hive_key_1 };
                    c_0 = c_0t;
                    c_1 = c_1t;
                    c_2 = c_2t;
                    c_3 = c_3t;
                    c_4 = c_4t;
                    key = keyt;

                }
                else
                {
                    COperations.custom_json custom_json = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_1,
                        required_auths = new string[] { },
                        required_posting_auths = new string[] { hive_user_1.ToLower() }
                    };
                    COperations.custom_json custom_json1 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_2,
                        required_auths = new string[] { },
                        required_posting_auths = new string[] { hive_user_1.ToLower() }
                    };
                    COperations.custom_json custom_json2 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_3,
                        required_auths = new string[] { },
                        required_posting_auths = new string[] { hive_user_1.ToLower() }
                    };
                    COperations.custom_json custom_json3 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_4,
                        required_auths = new string[] { },
                        required_posting_auths = new string[] { hive_user_1.ToLower() }
                    };
                    COperations.custom_json custom_json4 = new COperations.custom_json
                    {
                        id = customid,
                        json = customjson_5,
                        required_auths = new string[] { },
                        required_posting_auths = new string[] { hive_user_1.ToLower() }
                    };

                    object[] c_0t = { custom_json };
                    object[] c_1t = { custom_json1 };
                    object[] c_2t = { custom_json2 };
                    object[] c_3t = { custom_json3 };
                    object[] c_4t = { custom_json4 };
                    string[] keyt = { hive_key_1 };
                    c_0 = c_0t;
                    c_1 = c_1t;
                    c_2 = c_2t;
                    c_3 = c_3t;
                    c_4 = c_4t;
                    key = keyt;
                }


                do
                {
                    now = DateTime.Now;
                    TimeSpan data = target - now;
                    Console.SetCursorPosition(0, 6);
                    Console.Write("Time Until Purchase [ " + data.ToString().Substring(0, data.ToString().LastIndexOf(".")) + " ]");
                } while (target > now);
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < attempts; i++)
                {
                    await Task.Delay(int.Parse(delay));
                    switch (i)
                    {
                        case 0:
                            try
                            {
                                if (demo != "false")
                                {
                                    string txid = i.ToString();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                                else
                                {
                                    string txid = oHived.broadcast_transaction(c_0, key);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }                                
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed");
                            }
                            break;
                        case 1:
                            try
                            {
                                if (demo != "false")
                                {
                                    string txid = i.ToString();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                                else
                                {
                                    string txid = oHived.broadcast_transaction(c_1, key);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed");
                            }
                            break;
                        case 2:
                            try
                            {
                                if (demo != "false")
                                {
                                    string txid = i.ToString();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                                else
                                {
                                    string txid = oHived.broadcast_transaction(c_2, key);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed");
                            }
                            break;
                        case 3:
                            try
                            {
                                if (demo != "false")
                                {
                                    string txid = i.ToString();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                                else
                                {
                                    string txid = oHived.broadcast_transaction(c_3, key);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed");
                            }
                            break;
                        case 4:
                            try
                            {
                                if (demo != "false")
                                {
                                    string txid = i.ToString();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                                else
                                {
                                    string txid = oHived.broadcast_transaction(c_4, key);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(txid);
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed");
                            }
                            break;

                        default:
                            break;
                    }

                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Done");

            }
            catch (Exception e)
            {
                Console.WriteLine(filepath);
                Console.WriteLine(Main_Settings.Read("Datetime"));
                Console.WriteLine(e);
            }
            await Task.Delay(10000);
            Environment.Exit(-1);           
        }

        private static string randomN()
        {
            //This function produces a random chain of letters 10 characters long for the transaction.

            String b = "abcdefghijklmnopqrstuvwxyz0123456789";
            int length = 10;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(36);
                random = random + b.ElementAt(a);
            }
            return random;
        }
    }
}
