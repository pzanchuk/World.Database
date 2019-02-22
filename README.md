# _Word Counter_

#### _02.15.2019_

#### By _**Pavel Zanchuk**_

## Description

_This program gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

## Specifications

* _Program will not accept empty field._
  * _Example input: (just click Enter)_
  * _Example output: "It's not a sentence"_
    * _(Since this is the simplest thing you can do being a user, or implement being a dev. I've decided to put this one first. Also, it will save time for both user and PC by preventing unusable inputs)_

* _Program will store user's input as a String type._
  * _Example input: "Hello there, I am a string"._
  * _Example output: "True" (Test will show that the type of user's input is correct type, which is string.)_
    * _(This spec comes in second, because before wasting time running the whole project I need to make sure I will be working with correct data types.)_

* _Program will report back amount of matched words in a sentence._
  * _Example input: word: "dog", sentence: "I love my dog and any other dog"_
  * _Example output: Word [dog] has been seen here 2 time/s_
    * _(Looks like this one is the most logical thing to use this program for, so it comes right after crucial specs .)_

* _Program will report back if there is no such word in a sentence._
  * _Example input: word: "cat", sentence: "Looking for word cat"_
  * _Example output: "Word [cat] has been seen here 0 time/s"_
    * _Current spec is a second logical thing to try while using this terminal app._

* _Program will return result as an Integer type._
  * _Example input: word: "am", sentence: "Hello there, I am a string"._
  * _Example output: "Pass"_
    * _This spec is just for testing PURPOSE._


## Setup/Installation Requirements
* _Navigate your web browser to https://github.com/pzanchuk/WordCounter.Solution_
* _Click the green button "Clone or download" on the repository page._
* _To download the repository choose "Open in Desktop" or "Download Zip"._
* _Alternatively, to clone the repository, type "git clone https://github.com/pzanchuk/WordCounter.Solution in the terminal". (Note!: git should be installed on your PC).  For more    information visit GitHub Help section Cloning a repository from GitHub:
https://help.github.com/articles/cloning-a-repository-from-github/_
* _To run the project in the terminal: navigate to ../WordCounter.Solution/WordCounter and ran these lines to restore files "dotnet restore" and "dotnet build", then "mcs Program.cs Models/MyClass.cs; mono Program.exe".(Note!: Mono and .NET Core SDK 1.1.4 must be installed on your machine"._
* _To run the project in browser: navigate to ../WordCounter.Solution/WordCounter and ran these lines to restore files "dotnet restore" and "dotnet build", then "dotnet run".(Note!: Mono and .NET Core SDK 1.1.4 must be installed on your machine". Open up web browser and connect to http://localhost:5000/ _


## Support and contact details

_For support please contact:_
_Pavel Zanchuk - buzzik@yahoo.com_

## Technologies Used

_This program was created using C#._

### License

*MIT License*

*Copyright (c) 2019 Pavel Zanchuk*

*Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*
