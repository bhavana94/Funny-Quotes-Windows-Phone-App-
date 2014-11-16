using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Text;
using System.IO.IsolatedStorage;
using System.IO;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace BeautifulQuotes.Pages
{
    public partial class Quotes : PhoneApplicationPage
    {
        //Integer for array index
        int i = 0;
        // Random number to display random quote on startup
        Random rand = new Random();
        //isolated storage filename
        
        // Constructor
        public Quotes()
        {
            InitializeComponent();
        }
        ImageBrush image = new ImageBrush();

        string[] array = new string[]
        {
            "Never take life seriously. \nNobody gets out alive anyway.\n\n",
            "Stop worrying about the \nworld ending today. \nIt's already tomorrow in Australia.\n\n",
            "Life is like a very long \nTV show, \nwithout a remote control.\n\n",
            "I love being married. \nIt's so great to find that one special person \nyou want to annoy for the \nrest of your life.\n\n",
            "The greatest pleasure in life is \ndoing what people say \nyou cannot do.\n\n",
            "I always try to cheer myself up \nby singing when I get sad. \nMost of the time, it turns out \nthat my voice is worse than my problems.\n\n",
            "I hate it when people see me at \nthe supermarket and they're like \n'Hey, what are you doing here?' \nI tell them \n'You know.. hunting elephants.\n\n",
            "When I stare at the sky, I see you. \nWhen I stare out into the ocean, I see you. \nWhen I'm looking at the moon, I see you. \nGeez! Would you move aside, \nyou're constantly getting in my way!\n\n",
            "I called the restaurant and I asked them \nif they take orders, \nwhen they said they do, \nI told them 'run outside naked!\n\n",
            "Some of the greatest ideas of all time \nhave come to people during Math class... \nnone of which had anything to do with Math.\n\n",
            "The ideal man doesn't smoke, \ndoesn't drink, \ndoesn't do drugs, \ndoesn't swear, \ndoesn't get angry, \ndoesn't exist.\n\n",
            "Love your enemies. \nIt makes them so damned mad.\n\n",
            "The road to success is always \nunder construction.\n\n",
            "Never let a fool kiss you, \nor a kiss fool you.\n\n",
            "Smile today, \ntomorrow could be worse.\n\n",
            "I am on a seafood diet. \nI see food, and \nI eat it.\n\n",
            "You know you are getting old \nwhen the candles on your birthday cake \nstart to cost more than the cake itself.\n\n",
            "To the guy who created \nimaginary numbers in Math: \nI hate you. \n\n",
            "The probability of meeting someone \nyou know increases a hundredfold \nwhen you're with someone \nyou're not supposed to be seen with.\n\n",
            "When a door closes another door should open, \nbut if it doesn't then \ngo in through the window.\n\n",
            "Dear Math, please grow up \nand solve your own problems, \nI'm tired of solving them for you.\n\n",
            "They say that love is more important \nthan money, but have you ever tried \nto pay your bills with a hug?\n\n",
            "The broccoli says \n'I look like a small tree', \nthe mushroom says \n'I look like an umbrella', \nthe walnut says \n'I look like a brain', \nand the banana says \n'Can we please change the subject?\n\n",
            "When my boss asked me \nwho is the stupid one, me or him? \nI told him everyone knows \nhe doesn't hire stupid people.\n\n",
            "If you think your boss is stupid, \nremember: you wouldn't have a job if \nhe was any smarter\n\n",
            "If you think nothing is impossible, \ntry slamming a revolving door.\n\n",
            "The difference between \nstupidity and genius \nis that genius has its limits.\n\n",
            "I'm not here to judge, \nI'm just pointing out \nall the mistakes you're making.\n\n",
            "I don't smoke, \ndon't drink, \ndon't do drugs, \nI only have one small problem, \nI lie.\n\n",
            "In grammar class the teacher asks \nher student 'When you sing you say \n'I sing' \nwhat do you say when \nyour brother is singing? \nI say 'shut up you're a \nterrible singer'",
            "I wish that all of my enemies \nhad three cars parked in front of their house. \nAn ambulance, \nfire truck and \npolice car\n\n",
            "There are no stupid questions, \njust stupid people.\n\n",
            "A man gifted his wife a diamond necklace \nfor there anniversary and then his wife \ndidn’t speak to him for 6 months.\nWas the neclace fake?\nNo. that was deal..!!\n\n",
            "A good lecture should be like a \nGirl’s mini skirt…\nLong enough to cover the subject\n & short enough to create interest..!\n\n",
            "Lines by School boy…\nLove is when i walk to other side of classroom\nto sharp my pencil, Just to See her..\nN then realize that,\nIm holding a pen..!! :-)\n\n",
            "Today’s Relationships:\nYou can touch each other,\nnot each others phones..!!\n\n",
            "Hard fact about youngsters,\nThey are always busy watching \nthe desktop wallpaper..\nwhenever their parents enter their room’\n\n",
            "What is the best example of \n‘once in a lifetime’ opportunity?\nA Mosquito lands on your wife’s face,\n& u get the rarest opportunity of your life..\nNever miss it!.\n\n",
            "A Fool Can Ask More Questions, \nThan A Wise Can Answer..\nNow We Know..\nwhy All Of Us ..Are Speechless \nDuring The Exam Viva.!\n\n",
            "Position of a husband is \njust like a Split AC…\nNo matter how loud he is outdoor,\nHe is designed to remain silent indoor! \n\n",
            "Girlfriend is Hot Water,\nLover is Mineral Water,\nWife is Corporation Water,\nRelationship is Kaveri Water,\nBut “FRIENDSHIP” is pure Rain Water!\n\n",
            "You know what COLLEGE means??\nC=Come\nO=On\nL=Lets\nL=Love\nE=Each\nG=Girl\nE=Equally\nSo every BOY goes to COLLEGE.\n\n",
            "Why does not Bangladesh have an\nOlympic team.??\nBecause\nall those who can jump, swim\n& run have already crossed the border.\n\n",
            "It is said that if you close your eyes, \nyou see the person you love the most.\nand when i do that,\nSlideShow begins.!\n\n",
            "Somewhere I Heard..\nLife is Beautiful..\nBut Very Soon I Released..\nLots of Conditions Apply..!!\n\n",
            "People dont care when they \nlose 1RS coin from their pocket.\nbut,They feel distressing when they \nlose 1RS from their mobile balance!..\n\n",
            "89% of teachers are suffering from \nthroat cancer problem by teaching students\nSo plz BUNK the classes as much as \npossible & save our TEACHERS.\n**HAPPY TEACHERS DAY**\n\n",
            "When in doubt about who's to blame. \nBlame the English \n\n",
            "Going to church doesn’t make you a Christian \nany more than going to a \ngarage makes you an automobile.\n\n",
            "The planet is fine. \nThe people are fucked.\n\n",
            "They love their hair because \nthey're not smart enough to \nlove something more interesting..\n\n",
           "When life gives you lemons, \nsquirt someone in the eye\n\n",
            "Don't be so humble - \nyou are not that great.\n\n",
            "I don't hate you.. I just don't \nlike that you exist!\n\n",
            "Once I pulled a job, \nI was so stupid. \nI picked a guy's pocket on an airplane \nand made a run for it!\n\n",
            "I’m not waiting until my hair turns white \nto become patient and wise. \nNope, I’m dyeing my hair tonight..\n\n",
            "Can I come in?\nNo! I'm in a towel!\nI'm blind!.\n\n",
            "Never trust people who smile constantly. \nThey're either selling something or \nnot very bright.\n\n",
            "I can tell if two people are in love \nby how they hold each other’s hands, \nand how thick their sanitation gloves are.\n\n",
            "If sex were shoes, \nI'd wear you out. \nBut I wouldn't wear you out \nin public.\n\n",
            "I want my kids to have the things in life \nthat I never had when I was growing up. \nThings like beards and chest hair.\n\n",
            "Life is pleasant. \nDeath is peaceful. \nIt's the transition that's troublesome\n\n",
            "When I came here, \nI couldn't speak a word of English, \nbut my sex life was perfect. \nNow my English is perfect but \nmy sex life is rubbish.\n\n",
            "A successful man is one who makes \nmore money than his wife can spend. \nA successful woman is one who \ncan find such a man..\n\n",
            "A day without sunshine is \nlike, you know, \nnight.\n\n",
            "People who think they know everything \nare a great annoyance to those of \nus who do.\n\n",
            "If the facts don't fit the theory, \nchange the facts..\n\n",
            "I always wanted to be somebody, \nbut now I realize \nI should have been more specific. \n\n",
            "Any girl can be glamorous. \nAll you have to do is \nstand still and look stupid..\n\n",
        };

       
        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {    
            i = rand.Next(1, array.Length - 2);
            quoteTextBlock.Text = array[i];
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
            ShareStatusTask task = new ShareStatusTask();
            task.Status = quoteTextBlock.Text;
            task.Show();
        }

        private void ApplicationBarMenuItem_Click_2(object sender, EventArgs e)
        {
            SmsComposeTask task = new SmsComposeTask();
            task.Body = quoteTextBlock.Text;
            task.Show();
        }

        private void ApplicationBarMenuItem_Click_3(object sender, EventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.Subject = "A Beautiful Quote";
            task.Body = quoteTextBlock.Text;
            task.Show();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = array.Length - 1;
            }
            else
            {
                i = i - 1;
            }
            quoteTextBlock.Text = array[i];
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            i = i + 1;
            
            if (i == (array.Length))
            {
                i = 0;
            }
            quoteTextBlock.Text = array[i];
        }
    }
}