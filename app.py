from datetime import datetime
from flask import Flask, render_template, request, redirect, url_for, send_from_directory

app = Flask(__name__)

@app.route("/")
def index(request):
    return render_template("mainMenu.html",title="Hexapawn")

@app.route('/favicon.ico')
def favicon():
    return send_from_directory(os.path.join(app.root_path, 'static'),
                               'favicon.ico', mimetype='image/vnd.microsoft.icon') 

@app.route("/singleplayer")
def singlePlayer():
    return render_template("singleplayer.html",title="Hexapawn")

@app.route("/multiplayer")
def multiplayer():
    return render_template("multiplayer.html",title="Hexapawn")


if __name__ == '__main__':
    app.run()
