# AI Cybersecurity Chatbot 

A simple Windows Presentation Foundation chatbot built in C# that teaches users about cybersecurity topics through conversational interaction. The bot validates usernames, stores user interests, and responds with topic-based answers while playing a greeting sound.

## Features

**1. User Authentication & Profiles**
- Username validation: letters only, no empty input
- `user_name` class handles new vs returning users
- Stores usernames in `user_names.txt` 
- Personalized welcome messages for new and returning users

**2. Chat Interface** 
- `submit_name` event handler validates and switches from username grid to chat grid
- `send` event handler sanitizes input and displays user messages
- `error_method` overloads render styled chat bubbles with colored borders
- User messages = Plum background, Bot messages = LightGray background
- Error/fallback messages highlighted in red

**3. AI Response Engine**
- `ai_check` method processes user input word-by-word
- Removes special characters via `RemoveSpecialCharacters`
- Filters stopwords using `respond` class `ignore` list
- Matches keywords to pre-written answers from `respond.answers`
- Random selection from multiple responses per topic
- Fallback messages when no match found

**4. Interest Tracking**
- Detects "interested in" phrases in user input
- Stores user interests in `interested_topic.txt` per username
- `auto_show_interest` reminds users of their interests every 3 messages
- Avoids duplicate interests using HashSet

**5. Voice Greeting**
- `voice_greeting` class plays `greet.wav` on startup using `SoundPlayer`
- Auto-resolves path from application directory

**6. Response Topics Covered**
The bot includes 10+ responses each for: greeting, purpose, cybersecurity, phishing, firewall, password, hacked account, fraud, malicious chatbot, VPN, plus emotional responses: frustrated, confused, worried, happy, sad, angry.


