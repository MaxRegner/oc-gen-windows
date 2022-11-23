using System;

namespace OC_Gen_Windows
{
    class EFIBuilder
    {
        using System;

namespace OC_Gen_Windows
{
    class EFIBuilder
    {
        public static void BuildEFI()
        {
            Console.WriteLine("Building EFI...");
        }
    }

}

# Path: Variables.cs
# Compare this snippet from Variables.cs:
# namespace OC_Gen_Windows
# {
#     class Variables
#     {
#         public static string[] intelHardware_laptop =
#      {
#             "Sandy Bridge",
#             "Ivy Bridge",
#             "Haswell",
#             "Broadwell",
#             "Skylake",
#             "Kaby Lake",
#             "Coffee Lake / Whiskey Lake",
#             "Coffee Lake Plus / Comet Lake",
#             "Ice Lake"
#         };

public_static_string[]intelHardware_laptop=
{
"Sandy_Bridge",
"Ivy_Bridge",
"Haswell",
"Broadwell",
"Skylake",
"Kaby_Lake",
"Coffee_Lake_/_Whiskey_Lake",
"Coffee_Lake_Plus_/_Comet_Lake",
"Ice_Lake"
};

#lets make the generate script
# Path: Generate.cs
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Gen_Windows
{
    class Generate
    {
        public static void GenerateOC()
        {
            Console.WriteLine("Generating OC...");
            string[] intelHardware_laptop =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_desktop =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_server =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_workstation =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_embedded =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_mobile =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_tablet =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] intelHardware_HEDT =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };
            string[] amdHardware =
            {
                "Sandy Bridge",
                "Ivy Bridge",
                "Haswell",
                "Broadwell",
                "Skylake",
                "Kaby Lake",
                "Coffee Lake / Whiskey Lake",
                "Coffee Lake Plus / Comet Lake",
                "Ice Lake"
            };  
          
            Console.WriteLine("Please select your CPU type:");
            Console.WriteLine("1. Intel");
            Console.WriteLine("2. AMD");
            string cpuType = Console.ReadLine();
            if (cpuType == "1")
            {
                Console.WriteLine("Please select your CPU generation:");
                Console.WriteLine("1. Sandy Bridge");
                Console.WriteLine("2. Ivy Bridge");
                Console.WriteLine("3. Haswell");
                Console.WriteLine("4. Broadwell");
                Console.WriteLine("5. Skylake");
                Console.WriteLine("6. Kaby Lake");
                Console.WriteLine("7. Coffee Lake / Whiskey Lake");
                Console.WriteLine("8. Coffee Lake Plus / Comet Lake");
                Console.WriteLine("9. Ice Lake");
                string cpuGeneration = Console.ReadLine();
                if (cpuGeneration == "1")
                {
                    Console.WriteLine("Please select your hardware type:");
                    Console.WriteLine("1. Laptop");
                    Console.WriteLine("2. Desktop");
                    Console.WriteLine("3. Server");
                    Console.WriteLine("4. Workstation");
                    Console.WriteLine("5. Embedded");
                    Console.WriteLine("6. Mobile");
                    Console.WriteLine("7. Tablet");
                    Console.WriteLine("8. HEDT");
                    string hardwareType = Console.ReadLine();
                    if (hardwareType == "1")
                    {
                        Console.WriteLine("Please select your hardware generation:");
                        Console.WriteLine("1. Sandy Bridge");
                        Console.WriteLine("2. Ivy Bridge");
                        Console.WriteLine("3. Haswell");
                        Console.WriteLine("4. Broadwell");
                        Console.WriteLine("5. Skylake");
                        Console.WriteLine("6. Kaby Lake");
                        Console.WriteLine("7. Coffee Lake / Whiskey Lake");
                        Console.WriteLine("8. Coffee Lake Plus / Comet Lake");
                        Console.WriteLine("9. Ice Lake");
                        string hardwareGeneration = Console.ReadLine();
                        if (hardwareGeneration == "1")
                        {
                            Console.WriteLine("Please select your SMBIOS:");
                            Console.WriteLine("1. MacBookPro11,1");
                            Console.WriteLine("2. MacBookPro11,2");
                            Console.WriteLine("3. MacBookPro11,3");
                            Console.WriteLine("4. MacBookPro11,4");
                            Console.WriteLine("5. MacBookPro11,5");
                            Console.WriteLine("6. MacBookPro12,1");
                            Console.WriteLine("7. MacBookPro13,1");
                            Console.WriteLine("8. MacBookPro13,2");
                            Console.WriteLine("9. MacBookPro13,3");
                            Console.WriteLine("10. MacBookPro14,1");
                            Console.WriteLine("11. MacBookPro14,2");
                            Console.WriteLine("12. MacBookPro14,3");
                            Console.WriteLine("13. MacBookPro15,1");
                            Console.WriteLine("14. MacBookPro15,2");
                            Console.WriteLine("15. MacBookPro15,3");
                            Console.WriteLine("16. MacBookPro15,4");
                            Console.WriteLine("17. MacBookPro16,1");
                            Console.WriteLine("18. MacBookPro16,2");

                            string smbios = Console.ReadLine();

                            if (smbios == "1")
                            {
                                Console.WriteLine("MacBookPro11,1");
                            }
                            else if (smbios == "2")
                            {
                                Console.WriteLine("MacBookPro11,2");
                            }
                            else if (smbios == "3")
                            {
                                Console.WriteLine("MacBookPro11,3");
                            }
                            else if (smbios == "4")
                            {
                                Console.WriteLine("MacBookPro11,4");
                            }
                            else if (smbios == "5")
                            {
                                Console.WriteLine("MacBookPro11,5");
                            }
                            else if (smbios == "6")
                            {
                                Console.WriteLine("MacBookPro12,1");
                            }
                            else if (smbios == "7")
                            {
                                Console.WriteLine("MacBookPro13,1");
                            }
                            else if (smbios == "8")
                            {
                                Console.WriteLine("MacBookPro13,2");
                            }
                            else if (smbios == "9")
                            {
                                Console.WriteLine("MacBookPro13,3");
                            }
                            else if (smbios == "10")
                            {
                                Console.WriteLine("MacBookPro14,1");
                            }
                            else if (smbios == "11")
                            {
                                Console.WriteLine("MacBookPro14,2");
                            }
                            else if (smbios == "12")
                            {
                                Console.WriteLine("MacBookPro14,3");
                            }
                            else if (smbios == "13")
                            {
                                Console.WriteLine("MacBookPro15,1");
                            }
                            else if (smbios == "14")
                            {
                                Console.WriteLine("MacBookPro15,2");
                            }
                            else if (smbios == "15")
                            {
                                Console.WriteLine("MacBookPro15,3");
                            }
                            else if (smbios == "16")
                            {
                                Console.WriteLine("MacBookPro15,4");
                            }
                            else if (smbios == "17")
                            {
                                Console.WriteLine("MacBookPro16,1");
                            }
                            else if (smbios == "18")
                            {
                                Console.WriteLine("MacBookPro16,2");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }

                        }

                    }

                }


                # once you have selected your CPU type, you can use the generate command to generate a config.plist for your system
                # you can also use the generate command to generate a config.plist for your system
                # you can also use the generate command to generate a config.plist for your system

                class GenerateCommand(Command):
                    """Generate a config.plist for your system."""

                    def execute(self, args: argparse.Namespace) -> None:
                        """Execute the command."""
                        if args.cpu_type is None:
                            print("Please select your CPU type:")
                            print("1. Intel")
                            print("2. AMD")
                            cpu_type = input()
                            if cpu_type == "1":
                                print("Please select your CPU generation:")
                                print("1. Sandy Bridge")
                                print("2. Ivy Bridge")
                                print("3. Haswell")
                                print("4. Broadwell")
                                print("5. Skylake")
                                print("6. Kaby Lake")
                                print("7. Coffee Lake / Whiskey Lake")
                                print("8. Coffee Lake Plus / Comet Lake")
                                print("9. Ice Lake")
                                cpu_generation = input()
                                if cpu_generation == "1":
                                    print("Please select your hardware type:")
                                    print("1. Laptop")
                                    print("2. Desktop")
                                    print("3. Server")
                                    print("4. Workstation")
                                    print("5. Embedded")
                                    print("6. Mobile")
                                    print("7. Tablet")
                                    print("8. HEDT")
                                    hardware_type = input()
                                    if hardware_type == "1":
                                        print("Please select your hardware generation:")
                                        print("1. Sandy Bridge")
                                        print("2. Ivy Bridge")
                                        print("3. Haswell")
                                        print("4. Broadwell")
                                        print("5. Skylake")
                                        print("6. Kaby Lake")
                                        print("7. Coffee Lake / Whiskey Lake")
                                        print("8. Coffee Lake Plus / Comet Lake")
                                        print("9. Ice Lake")
                                        hardware_generation = input()
                                        if hardware_generation == "1":
                                            print("Please select your SMBIOS:")
                                            print("1. MacBookPro11,1")
                                            print("2. MacBookPro11,2")
                                            print("3. MacBookPro11,3")
                                            print("4. MacBookPro11,4")
                                            print("5. MacBookPro11,5")
                                            print("6. MacBookPro12,1")
                                            print("7. MacBookPro13,1")
                                            print("8. MacBookPro13,2")
                                            print("9. MacBookPro13,3")
                                            print("10. MacBookPro14,1")
                                            print("11. MacBookPro14,2")
                                            print("12. MacBookPro14,3")
                                            print("13. MacBookPro15,1")
                                            print("14. MacBookPro15,2")
                                            print("15. MacBookPro15,3")
                                            print("16. MacBookPro15,4")
                                            print("17. MacBookPro16,1")
                                            print("18. MacBookPro16,2")

                                            smbios = input()
                                            if smbios == "1":
                                                print("MacBookPro11,1")
                                            elif smbios == "2":
                                                print("MacBookPro11,2")
                                            elif smbios == "3":
                                                print("MacBookPro11,3")
                                            elif smbios == "4":
                                                print("MacBookPro11,4")
                                            elif smbios == "5":
                                                print("MacBookPro11,5")
                                            elif smbios == "6":
                                                print("MacBookPro12,1")
                                            elif smbios == "7":
                                                print("MacBookPro13,1")
                                            elif smbios == "8":
                                                print("MacBookPro13,2")
                                            elif smbios == "9":
                                                print("MacBookPro13,3")
                                            elif smbios == "10":
                                                print("MacBookPro14,1")
                                            elif smbios == "11":
                                                print("MacBookPro14,2")
                                            elif smbios == "12":
                                                print("MacBookPro14,3")
                                            elif smbios == "13":
                                                print("MacBookPro15,1")
                                            elif smbios == "14":
                                                print("MacBookPro15,2")
                                            elif smbios == "15":
                                                print("MacBookPro15,3")
                                            elif smbios == "16":
                                                print("MacBookPro15,4")
                                            elif smbios == "17":
                                                print("MacBookPro16,1")
                                            elif smbios == "18":
                                                print("MacBookPro16,2")
                                            else:
                                                print("Invalid input")
                                        elif hardware_generation == "2":
                                            print("Please select your SMBIOS:")
                                            print("1. MacBookPro11,1")
                                            print("2. MacBookPro11,2")
                                            print("3. MacBookPro11,3")
                                            print("4. MacBookPro11,4")
                                            print("5. MacBookPro11,5")
                                            print("6. MacBookPro12,1")
                                            print("7. MacBookPro13,1")
                                            print("8. MacBookPro13,2")
                                            print("9. MacBookPro13,3")
                                            print("10. MacBookPro14,1")
                                            print("11. MacBookPro14,2")
                                            print("12. MacBookPro14,3")
                                            print("13. MacBookPro15,1")
                                            print("14. MacBookPro15,2")
                                            print("15. MacBookPro15,3")
                                            print("16. MacBookPro15,4")
                                            print("17. MacBookPro16,1")
                                            print("18. MacBookPro16,2")

                                            smbios = input()
                                            if smbios == "1":
                                                print("MacBookPro11,1")
                                            elif smbios == "2":
                                                print("MacBookPro11,2")
                                            elif smbios == "3":
                                                print("MacBookPro11,3")
                                            elif smbios == "4":
                                                print("MacBookPro11,4")
                                            elif smbios == "5":
                                                print("MacBookPro11,5")
                                            elif smbios == "6":
                                                print("MacBookPro12,1")
                                            elif smbios == "7":
                                                print("MacBookPro13,1")
                                            elif smbios == "8":
                                                print("MacBookPro13,2")
                                            elif smbios == "9":
                                                print("MacBookPro13,3")
                                            elif smbios == "10":
                                                print("MacBookPro14,1")
                                            elif smbios == "11":
                                                print("MacBookPro14,2")
                                            elif smbios == "12":
                                                print("MacBookPro14,3")
                                            elif smbios == "13":
                                                print("MacBookPro15,1")
                                            elif smbios == "14":
                                                print("MacBookPro15,2")
                                            elif smbios == "15":
                                                print("MacBookPro15,3")
                                            elif smbios == "16":
                                                print("MacBookPro15,")
                                            elif smbios == "17":

                                                print("MacBookPro16,1")
                                            elif smbios == "18":
                                                print("MacBookPro16,2")
                                            else:
                                                print("Invalid input")  
                                        elif hardware_generation == "3":    

                                            print("Please select your SMBIOS:")
                                            print("1. MacBookPro11,1")
                                            print("2. MacBookPro11,2")
                                            print("3. MacBookPro11,3")
                                            print("4. MacBookPro11,4")
                                            print("5. MacBookPro11,5")
                                            print("6. MacBookPro12,1")
                                            print("7. MacBookPro13,1")
                                            print("8. MacBookPro13,2")
                                            print("9. MacBookPro13,3")
                                            print("10. MacBookPro14,1")
                                            print("11. MacBookPro14,2")
                                            print("12. MacBookPro14,3")
                                            print("13. MacBookPro15,1")
                                            print("14. MacBookPro15,2")
                                            print("15. MacBookPro15,3")
                                            print("16. MacBookPro15,4")
                                            print("17. MacBookPro16,1")
                                            print("18. MacBookPro16,2")

                                            smbios = input()
                                            if smbios == "1":
                                                print("MacBookPro11,1")
                                            elif smbios == "2":
                                                print("MacBookPro11,2")
                                            elif smbios == "3":
                                                print("MacBookPro11,3")
                                            elif smbios == "4":
                                                print("MacBookPro11,4")
                                            elif smbios == "5":
                                                print("MacBookPro11,5")
                                            elif smbios == "6":
                                                print("MacBookPro12,1")
                                            elif smbios == "7":
                                                print("MacBookPro13,1")
                                            elif smbios == "8":
                                                print("MacBookPro13,2")
                                            elif smbios == "9":
                                                print("MacBookPro13,3")
                                            elif smbios == "10":
                                                print("MacBookPro14,1")
                                            elif smbios == "11":
                                                print("MacBookPro14,2")
                                            elif smbios == "12":
                                                print("MacBookPro14,3")
                                            elif smbios == "13":
                                                print("MacBookPro15,1")
                                            elif smbios == "14":
                                                print("MacBookPro15,2")
                                            elif smbios == "15":
                                                print("MacBookPro15,3")
                                            elif smbios == "16":
                                                print("MacBookPro15")

                                                #once this has been done, lastly we need to add the SMBIOS to the config.plist
                                                #this is done by adding the following to the config.plist
                                                #<key>SMBIOS</key>
                                                #<dict>
                                                #<key>BoardProduct</key>
                                                #<string>Mac-2BD1B31983FE1663</string>
                                                #<key>BoardRevision</key>
                                                #<string>1.0</string>
                                                #<key>BoardSerialNumber</key>
                                                #<string>C02VH0YAD6WP</string>
                                                #<key>BoardType</key>
                                                #<integer>10</integer>
                                                #<key>ChassisAssetTag</key>
                                                #<string>Mac-2BD1B31983FE1663</string>
                                                #<key>ChassisSerialNumber</key>
                                                #<string>C02VH0YAD6WP</string>
                                                #<key>ChassisType</key>
                                                #<integer>3</integer>
                                                #<key>ProcessorType</key>
                                                #<integer>103</integer>
                                                #<key>SystemFamily</key>
                                                #<string>MacBookPro</string>
                                                #<key>SystemMemoryStatus</key>
                                                #<string>Auto</string>
                                                #<key>SystemProductName</key>
                                                #<string>MacBookPro15,1</string>
                                                #<key>SystemSerialNumber</key>
                                                #<string>C02VH0YAD6WP</string>
                                                #<key>SystemSKU</key>
                                                #<string>Mac-2BD1B31983FE1663</string>
                                                #<key>SystemUUID</key>
                                                #<string>00000000-0000-0000-0000-000000000000</string>
                                                #</dict>

        }

        
    }
}
