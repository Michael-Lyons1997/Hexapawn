from wsgiref.simple_server import make_server
from pyramid.config import Configurator
from pyramid.response import Response
from flask import Flask, request, render_template
import os

app = Flask(__name__)

def index(request):
    return render_template("mainMenu.html",title="Hexapawn")

@app.get("/singlePlayer")
def singlePlayer(request):
    return render_template("singleplayer.html",title="Hexapawn")

@app.get("/multiplayer")
def multiplayer(request):
    return render_template("singleplayer.html",title="Hexapawn")


if __name__ == '__main__':
    port = int(os.environ.get("PORT"))
    with Configurator() as config:
        config.add_route('menu', '/')
        config.add_view(index, route_name='menu')
        app = config.make_wsgi_app()
    server = make_server('0.0.0.0', port, app)
    server.serve_forever()
