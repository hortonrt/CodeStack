import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stack',
  templateUrl: './stack.component.html',
  styleUrls: ['./stack.component.scss'],
})
export class StackComponent implements OnInit {
  icons: any[] = [
    { name: 'Angular', link: 'https://angular.io/', img: 'angular.svg' },
    { name: 'MacOS', link: 'https://www.apple.com', img: 'apple.svg' },
    { name: 'BitBucket', link: 'https://bitbucket.org/', img: 'bitbucket.svg' },
    {
      name: 'Bootstrap',
      link: 'https://www.getbootstrap.com',
      img: 'bootstrap.svg',
    },
    {
      name: 'CSS3',
      link: 'https://www.w3.org/TR/2001/WD-css3-roadmap-20010523/',
      img: 'css3.svg',
    },
    {
      name: 'Microsoft .NET',
      link: 'https://www.microsoft.com/net',
      img: 'dotnet.svg',
    },
    {
      name: 'ECMAScript 6',
      link: 'http://es6-features.org/#Constants',
      img: 'es6.svg',
    },
    {
      name: 'Font Awesome',
      link: 'https://fontawesome.com/',
      img: 'fontawesome.svg',
    },
    { name: 'git', link: 'https://git-scm.com/', img: 'git.svg' },
    { name: 'github', link: 'https://github.com/', img: 'github.svg' },
    {
      name: 'Highcharts',
      link: 'https://www.highcharts.com/',
      img: 'highcharts.svg',
    },
    { name: 'HTML5', link: 'https://www.w3.org/TR/html52/', img: 'html5.svg' },
    { name: 'Jasmine', link: 'https://jasmine.github.io/', img: 'jasmine.svg' },
    {
      name: 'JavaScript',
      link: 'https://www.javascript.com/',
      img: 'javascript.svg',
    },
    {
      name: 'Jira',
      link: 'https://www.atlassian.com/software/jira',
      img: 'jira.svg',
    },
    { name: 'jQuery', link: 'https://jquery.com/', img: 'jquery.svg' },
    { name: 'json', link: 'https://www.json.org/', img: 'json.svg' },
    {
      name: 'Karma',
      link: 'https://karma-runner.github.io/2.0/index.html',
      img: 'karma.svg',
    },
    { name: 'momentjs', link: 'https://momentjs.com/', img: 'momentjs.svg' },
    { name: 'nodejs', link: 'https://nodejs.org/en/', img: 'nodejs.svg' },
    { name: 'npm', link: 'https://www.npmjs.com/', img: 'npm.svg' },
    { name: 'Redux', link: 'https://redux.js.org/', img: 'redux.svg' },
    { name: 'SASS', link: 'https://sass-lang.com/', img: 'sass.svg' },
    {
      name: 'TypeScript',
      link: 'https://www.typescriptlang.org/',
      img: 'typescript.svg',
    },
    {
      name: 'VSCode',
      link: 'https://code.visualstudio.com/',
      img: 'vscode.svg',
    },
    {
      name: 'Microsoft Windows',
      link: 'https://www.microsoft.com/en-us/windows',
      img: 'windows.svg',
    },
  ];
  constructor() {}

  ngOnInit() {}
}
