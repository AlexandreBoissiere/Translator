using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FrenchImplelentation
{
    public static class French
    {
        private class Word
        {
            public string function = "";
            public string word = "";
            public Word(string function, string word)
            {
                this.function = function;
                this.word = word;
            }
        }
        private class Sentence
        {
            List<Word> words;
            public string sentence = "";
            public string language = "";
            public Sentence(List<Word> words, string language)
            {
                this.words = words;
                this.language = language;
            }
            public void MakeSentence()
            {
                List<Word> Temp = words;

                if (language == "latin")
                {
                    for (int i = 0; i < Temp.Count; i++)
                    {
                        if (Temp[i].function == "first word")
                        {
                            sentence += $"{Temp[i].word[0].ToString().ToUpper()}";
                            Temp[i].word.Remove(0, 1);
                            sentence += $"{Temp[i].word}";
                        }
                        if (Temp[i].function == "verb")
                        {
                            sentence += $"{Temp[i].word} ";
                            Temp.RemoveAt(i);
                        }
                        else if (Temp[i].function == "other")
                        {
                            sentence += $"{Temp[i].word} ";
                            Temp.RemoveAt(i);
                        }
                        else if (Temp[i].function == "last word")
                        {
                            sentence += $"{Temp[i].word}.";
                            Temp.RemoveAt(i);
                        }
                    }
                    return;
                }
            }
        }
        public static string ToFrench(string text, string language)
        {
            Sentence sentence = new Sentence(new List<Word>(), "");

            if (language == "latin")
            {
                List<string> words = text.Split(new char[] { ' ' , ',', '.', ';', '?', '!', ':'}).ToList();
                string[] separators = new string[] { " ", ",", ".", ";", "?", "!" };
                List<Word> pretranslated = new List<Word>();
                for (int i = 0; i < words.Count; i++)
                {
                    for (int j = 0; j < separators.Length; j++)
                    {
                        if (words[i] == separators[j])
                        {
                            words.RemoveAt(i);
                        }
                    }
                }

                for (int iter = 0; iter < words.Count; iter++)
                {
                    string word = words[iter];

                    string[] LatinVerbs = File.ReadAllLines("Latin/verbs.data");
                    string[] FrenchVerbs = File.ReadAllLines("French/verbs.data");
                    string[] LatinNouns = File.ReadAllLines("Latin/nouns.data");
                    string[] FrenchNouns = File.ReadAllLines("French/nouns.data");

                    for (int i = 0; i < LatinVerbs.Length; i++)
                    {
                        LatinVerbs[i] = LatinVerbs[i].Replace("\n", "");
                    }
                    for (int i = 0; i < FrenchVerbs.Length; i++)
                    {
                        FrenchVerbs[i] = FrenchVerbs[i].Replace("\n", "");
                    }
                    for (int i = 0; i < LatinNouns.Length; i++)
                    {
                        LatinNouns[i] = LatinNouns[i].Replace("\n", "");
                    }
                    for (int i = 0; i < FrenchNouns.Length; i++)
                    {
                        FrenchNouns[i] = FrenchNouns[i].Replace("\n", "");
                    }

                    for (int i = 0; i < LatinVerbs.Length; i++)
                    {
                        if (word == LatinVerbs[i])
                        {
                            pretranslated.Add(new Word("verb", FrenchVerbs[i]));
                            break;
                        }
                    }

                    for (int i = 0; i < LatinNouns.Length; i++)
                    {
                        if (word == LatinNouns[i] && iter == 0)
                        {
                            pretranslated.Add(new Word("first word", FrenchNouns[i]));
                            break;
                        }
                        else if (word == LatinNouns[i])
                        {
                            pretranslated.Add(new Word("other", FrenchNouns[i]));
                            break;
                        }
                    }                    
                }
                sentence = new Sentence(pretranslated, "latin");
                sentence.MakeSentence();
            }
            if (sentence.sentence == "")
            {
                throw new Exception("Error while translated !");
            }
            return sentence.sentence;
        }
    }
}
