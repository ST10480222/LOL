using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL
{
    
    public class respond
    {//start of a class
        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor

            answers(reply);
            words(ignore);


        }//end of constructor

        //method to store the list of words
        private void words(ArrayList ignoring)
        {//
         //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//




        public void answers(ArrayList add_answers)
        {//start of method




            //greeting
            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");
            add_answers.Add("greeting hello! it's nice to chat with you today.");
            add_answers.Add("greeting hi there! how can i assist you today ?");
            add_answers.Add("greeting hey! hope you're having a wonderful day.");
            add_answers.Add("greeting welcome! i'm ready to help you.");
            add_answers.Add("greeting good day! what would you like to know ?");
            add_answers.Add("greeting hi! feel free to ask me anything about cybersecurity.");
            add_answers.Add("greeting nice to see you! how may i help you today ?");


            //purpose
            add_answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");
            add_answers.Add("purpose i am here to answer cybersecurity questions and provide online safety tips.");
            add_answers.Add("purpose i help people learn how to protect their digital information.");
            add_answers.Add("purpose my goal is to improve your cybersecurity awareness.");
            add_answers.Add("purpose i guide users on safe internet practices.");
            add_answers.Add("purpose i provide support and information about online threats.");
            add_answers.Add("purpose i teach users how to stay secure while using technology.");
            add_answers.Add("purpose i help users avoid cyber threats and scams.");


            //cybersecurity
            add_answers.Add("cybersecurity cybersecurity is about protecting systems and networks from digital threats.");
            add_answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            add_answers.Add("cybersecurity it focuses on securing digital information and systems.");
            add_answers.Add("cybersecurity cybersecurity helps keep your personal information safe online.");
            add_answers.Add("cybersecurity it protects computers, networks and data from hackers.");
            add_answers.Add("cybersecurity it includes tools and practices that improve online safety.");
            add_answers.Add("cybersecurity cybersecurity reduces the risk of cyberattacks.");
            add_answers.Add("cybersecurity it helps prevent unauthorized access to systems.");
            add_answers.Add("cybersecurity cybersecurity is important for both individuals and businesses.");
            add_answers.Add("cybersecurity it helps users stay safe while using the internet.");


            //phishing
            add_answers.Add("phishing phishing is a scam where attackers pretend to be trusted sources to steal information.");
            add_answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            add_answers.Add("phishing attackers use deception to make users believe they are legitimate.");
            add_answers.Add("phishing phishing emails often ask users to click suspicious links.");
            add_answers.Add("phishing scammers may pretend to be banks or companies.");
            add_answers.Add("phishing always verify suspicious emails before responding.");
            add_answers.Add("phishing avoid sharing passwords through unknown links.");
            add_answers.Add("phishing phishing attacks can happen through email, sms or fake websites.");
            add_answers.Add("phishing cybercriminals use phishing to steal personal information.");
            add_answers.Add("phishing be cautious of urgent messages asking for sensitive details.");


            //firewall
            add_answers.Add("firewall a firewall controls network traffic based on security rules.");
            add_answers.Add("firewall it helps block unwanted access to your device or network.");
            add_answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");
            add_answers.Add("firewall firewalls help prevent unauthorized access.");
            add_answers.Add("firewall they are important for network security.");
            add_answers.Add("firewall a firewall can monitor incoming and outgoing traffic.");
            add_answers.Add("firewall it helps protect systems from hackers.");
            add_answers.Add("firewall most modern operating systems include built-in firewalls.");
            add_answers.Add("firewall firewalls improve online safety.");
            add_answers.Add("firewall organizations use firewalls to secure their networks.");


            //password
            add_answers.Add("password a password is used to secure access to your accounts or devices.");
            add_answers.Add("password it should be strong, long and not easy to guess.");
            add_answers.Add("password avoid using personal details when creating one.");
            add_answers.Add("password use a mix of letters, numbers and symbols.");
            add_answers.Add("password never share your passwords with strangers.");
            add_answers.Add("password changing passwords regularly improves security.");
            add_answers.Add("password avoid using the same password for multiple accounts.");
            add_answers.Add("password strong passwords reduce the risk of hacking.");
            add_answers.Add("password password managers can help keep passwords secure.");
            add_answers.Add("password always keep your passwords private.");


            //hacked account
            add_answers.Add("hacked account immediately secure your account and log out of all devices.");
            add_answers.Add("hacked account contact support if your account has been compromised.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");
            add_answers.Add("hacked account change your password as soon as possible.");
            add_answers.Add("hacked account check for suspicious activity on your account.");
            add_answers.Add("hacked account notify your contacts if your account was misused.");
            add_answers.Add("hacked account review your security settings carefully.");
            add_answers.Add("hacked account remove unknown devices linked to your account.");
            add_answers.Add("hacked account report the issue to the platform support team.");
            add_answers.Add("hacked account use strong passwords to prevent future attacks.");


            //fraud
            add_answers.Add("fraud contact your bank immediately if fraud is detected.");
            add_answers.Add("fraud report suspicious financial activity to the authorities.");
            add_answers.Add("fraud monitor your accounts for unusual activity.");
            add_answers.Add("fraud avoid sharing banking details with strangers.");
            add_answers.Add("fraud scammers often create urgency to trick victims.");
            add_answers.Add("fraud always verify payment requests before sending money.");
            add_answers.Add("fraud online fraud can happen through fake websites or emails.");
            add_answers.Add("fraud report fraudulent messages immediately.");
            add_answers.Add("fraud be cautious of offers that seem too good to be true.");
            add_answers.Add("fraud secure your accounts with strong passwords.");


            //malicious chatbot
            add_answers.Add("malicious chatbot malicious bots often create urgency to trick users.");
            add_answers.Add("malicious chatbot fake chatbots may ask for sensitive information.");
            add_answers.Add("malicious chatbot be cautious if a bot pressures you for personal data.");
            add_answers.Add("malicious chatbot never share passwords with unknown chatbots.");
            add_answers.Add("malicious chatbot suspicious chatbots may pretend to be customer support.");
            add_answers.Add("malicious chatbot always verify chatbot sources before trusting them.");
            add_answers.Add("malicious chatbot malicious bots may send dangerous links.");
            add_answers.Add("malicious chatbot trusted companies do not ask for sensitive details carelessly.");
            add_answers.Add("malicious chatbot fake bots can spread scams online.");
            add_answers.Add("malicious chatbot report suspicious chatbot behavior immediately.");


            //vpn
            add_answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            add_answers.Add("vpn it encrypts your internet traffic for safety.");
            add_answers.Add("vpn it improves security when using public networks.");
            add_answers.Add("vpn a vpn helps hide your online activity.");
            add_answers.Add("vpn it adds an extra layer of privacy online.");
            add_answers.Add("vpn many people use vpns to browse securely.");
            add_answers.Add("vpn vpns reduce the risk of hackers spying on data.");
            add_answers.Add("vpn it is useful when using unsecured internet connections.");
            add_answers.Add("vpn a vpn can improve online privacy.");
            add_answers.Add("vpn always choose a trusted vpn provider.");


            //frustrated
            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");
            add_answers.Add("frustrated i know this situation can be annoying, but we'll solve it.");
            add_answers.Add("frustrated don't worry, i'll guide you through the problem.");
            add_answers.Add("frustrated let's try another solution together.");
            add_answers.Add("frustrated i understand how difficult this can feel.");
            add_answers.Add("frustrated we'll sort this issue out step by step.");
            add_answers.Add("frustrated stay calm, we can fix the problem together.");
            add_answers.Add("frustrated i'm here to support you until the issue is solved.");


            //confused
            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");
            add_answers.Add("confused i'll simplify the explanation for you.");
            add_answers.Add("confused take your time, learning new things can be challenging.");
            add_answers.Add("confused feel free to ask questions if something is unclear.");
            add_answers.Add("confused i can explain it in a different way if needed.");
            add_answers.Add("confused let's go through it together carefully.");
            add_answers.Add("confused don't stress, i'll make it easier to understand.");
            add_answers.Add("confused confusion is part of learning, and i'm here to help.");


            //worried
            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");
            add_answers.Add("worried we'll work together to improve your security.");
            add_answers.Add("worried take action quickly to reduce any risks.");
            add_answers.Add("worried many online problems can be resolved with the right steps.");
            add_answers.Add("worried i'll guide you on what to do next.");
            add_answers.Add("worried securing your accounts is the first important step.");
            add_answers.Add("worried try to remain calm while we fix the issue.");
            add_answers.Add("worried your safety online is important and i'm here to assist.");


            //happy
            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");
            add_answers.Add("happy that's wonderful news!");
            add_answers.Add("happy great! keep up the positive energy.");
            add_answers.Add("happy i'm glad you're feeling good today.");
            add_answers.Add("happy positivity makes learning easier and more fun.");
            add_answers.Add("happy that's amazing to hear!");
            add_answers.Add("happy keep smiling and stay positive.");
            add_answers.Add("happy i'm excited that things are going well for you.");


            //sad
            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");
            add_answers.Add("sad remember that difficult moments do not last forever.");
            add_answers.Add("sad take care of yourself and try not to stress too much.");
            add_answers.Add("sad i'm here to support you however i can.");
            add_answers.Add("sad sometimes taking a short break can help.");
            add_answers.Add("sad i hope tomorrow brings better moments for you.");
            add_answers.Add("sad you're not alone, and support is always available.");
            add_answers.Add("sad stay strong, things can get better with time.");


            //angry
            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");
            add_answers.Add("angry let's focus on solving the problem calmly.");
            add_answers.Add("angry i understand this situation is frustrating.");
            add_answers.Add("angry we'll work together to find a solution.");
            add_answers.Add("angry try not to let the issue overwhelm you.");
            add_answers.Add("angry i'm ready to help you through this problem.");
            add_answers.Add("angry staying calm can make solving the issue easier.");
            add_answers.Add("angry let's handle the problem one step at a time.");
        }//end of method





    }

    }
    
    
