ConsoleGPT
A simple way to interact and log results from OpenAI ChatGPT.
Uses OpenAI by OkGoDoIt nuget package to communicate with OpenAI

The API key should be stored in:
\Users\<<user>>\AppData\Local\ConsoleGPT\settings.json
If this file doesn't exist it will try and create, asking permission first.

Or you can add it directly, if you want replace
var api = new OpenAIAPI(config.KeyValue["ApiKeyOpenAI"]);
with
var api = new OpenAIAPI(<<your key>>);

Written by John Rasmussen 4/15/2023 

MIT License 
Copyright 2023 John Rasmussen
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy,
modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF
OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
