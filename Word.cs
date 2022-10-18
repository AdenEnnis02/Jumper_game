
using System.Net;
class Word{
    List<string> words = new List<string>();

    play_again = ''
while play_again != 'no':
    
    string[] secret_words = {'snickers', 'reeses', 'milkyway', 'kitkat', 'skittles', 'butterfinger', 'babyruth', 'herseys', 'payday', 'crunch', 'almondjoy', 'twix', 'heath'}
    secret_word = random.choice(secret_words)
    guesses = 0
    guess = ''
    i = 0

    print('Lets play WORDLE!\n')
    print('Your hint is: ', end='')
    for letter in secret_word:
        print('_', end=' ')

    while guess != secret_word:
        guesses = guesses + 1
        guess = input('\nWhat is your guess? ')

        if guess != secret_word:   
            print('Your hint is:', end='')
            for i, letter in enumerate(guess):
                if letter in secret_word:
                    if i < len(secret_word) and secret_word[i] == letter:
                            print(letter.upper(), end=' ')
                    else: 
                        print(letter.lower(), end=' ')    
                else: 
                    print('_', end=' ')
        else:
            print('\nYou got it!')
            print(f'It took you: {guesses} guesses.')
            play_again = input('Do you want to play again?(yes/no) ')
else:
    print('\nThank you for playing!')

string GetRandomWord(){
    webClient wc = new webClient;
    string wordList = wc.DownloadString("http://dictionary-thesaurus.com/wordlists/Adjectives%28929%29.txt");
    string[] words = wordList.Split('\n');
    Random ran = new Random();
    return words[ran.Next(0, words.Length -1)];
}

}