docker run -it --rm -p 4000:4000 -v D:\MRGestures_GithubPages:/usr/src/app starefossen/github-pages


REM to see the running docker containers (dockerId is in the first column):
REM		docker ps
REM to kill a running container:
REM		docker kill <dockerId>
REM to start a shell in a running container:
REM		docker exec -it <dockerId> /bin/sh
REM current directory will be /usr/src/app which is the source directory of Jekyll.

REM Jekyll uses kramdown as markdown parser and Rouge as syntax highlighter for code
REM to list the available Rouge themes:
REM		rougify help style
REM to generate a css file for a given theme:
REM		rougify style github >assets/css/github.css
